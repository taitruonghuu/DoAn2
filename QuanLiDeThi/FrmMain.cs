using QuanLiDeThi.DAO;
using QuanLiDeThi.DTO;
using QuanLiDeThi.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
using System.IO;
using System.Data;
using System.Text;

namespace QuanLiDeThi
{
    public partial class FrmMain : Form
    {
        private Dictionary<string, List<Question>> exams = new Dictionary<string, List<Question>>();
        private List<Question> easyQuestions;
        private List<Question> mediumQuestions;
        private List<Question> hardQuestions;
        List<Question> questionData = new List<Question>();

        private static readonly Random rand = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Events.

        // MenuStrip.
        private void TSMIAddExamPaper_Click(object sender, EventArgs e)
        {
            var frmExamInput = new FrmExamInput();
            Hide();
            frmExamInput.ShowDialog();
            LoadQuestionByDifficultLevel();
            Show();
        }

        private void TSMIManageClass_Click(object sender, EventArgs e)
        {
            var frmClassRoom = new FrmClassRoom();
            Hide();
            frmClassRoom.ShowDialog();
            LoadClassRoom();
            Show();
        }

        private void TSMIManageSubject_Click(object sender, EventArgs e)
        {
            var frmSubject = new FrmSubject();
            Hide();
            frmSubject.ShowDialog();
            Show();
        }

        // Others.
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadClassRoom();
            LoadQuestionByDifficultLevel();
        }

        private void LoadClassRoom()
        {
            CbClassRoom.DataSource = ClassRoomDao.Instance.GetAll();
            CbClassRoom.ValueMember = "Id";
            CbClassRoom.DisplayMember = "Name";
        }

        private void LoadQuestionByDifficultLevel()
        {
            easyQuestions = QuestionDao.Instance.GetAllByDifficulty(Difficulty.Easy);
            mediumQuestions = QuestionDao.Instance.GetAllByDifficulty(Difficulty.Medium);
            hardQuestions = QuestionDao.Instance.GetAllByDifficulty(Difficulty.Hard);
        }

        private void CbClassRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cbClassRoom)
            {
                if (int.TryParse(cbClassRoom.SelectedValue.ToString(), out int classId))
                {
                    List<Subject> subjects = SubjectDao.Instance.GetByClassId(classId);
                    int rowsCount = subjects.Count;

                    if (rowsCount > 0)
                    {
                        CbSubjects.DataSource = subjects;
                        CbSubjects.ValueMember = "Id";
                        CbSubjects.DisplayMember = "Name";
                    }
                    else
                    {
                        CbSubjects.DataSource = null;
                    }
                }
            }
        }

        private void GenerateExam()
        {
            int examPaperCodeQnt = (int)NmExamPaperCodeQnt.Value;
            int totalQuestions = (int)NmToltalQuestion.Value;
            // Cấu trúc đề tạm thời: 70% dễ, 20% trung bình và 10% khó.
            int easyCount = (int)(0.7 * totalQuestions);
            int mediumCount = (int)(0.2 * totalQuestions);
            int hardCount = totalQuestions - easyCount - mediumCount;

            string subjectCode = SubjectDao.Instance.GetById((int)CbSubjects.SelectedValue).Code;

            exams.Clear();
            questionData.Clear();

            try
            {
                ShuffleList(easyQuestions);
                ShuffleList(mediumQuestions);
                ShuffleList(hardQuestions);

                questionData.AddRange(easyQuestions.Take(easyCount));
                questionData.AddRange(mediumQuestions.Take(mediumCount));
                questionData.AddRange(hardQuestions.Take(hardCount));

                for (int i = 0; i < examPaperCodeQnt; i++)
                {
                    string examPaperCode = $"{subjectCode}_{i + 1}";
                    ShuffleList(questionData);
                    List<Question> q = new List<Question>();
                    q.AddRange(questionData);
                    exams.Add(examPaperCode, q);
                }

                MessageBox.Show("Tạo đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Có lỗi khi tạo đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportExam_Click(object sender, EventArgs e)
        {
            GenerateExam();

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var pair in exams)
                    {
                        // Mở file và ghi dữ liệu theo mẫu.
                        Document examPaper = new Document("MauDeThi.doc");
                        examPaper.MailMerge.Execute(new[] { "TenTruong" }, new[] { TxtSchoolName.Text });
                        examPaper.MailMerge.Execute(new[] { "Ma_De" }, new[] { pair.Key.ToString() });
                        examPaper.MailMerge.Execute(new[] { "Mon" }, new[] { CbSubjects.Text });
                        examPaper.MailMerge.Execute(new[] { "Thoi_Gian" }, new[] { NmDuration.Value.ToString() });
                        DateTime selectedExamDate = DtpExamDate.Value;
                        int day = selectedExamDate.Day;
                        int month = selectedExamDate.Month;
                        int year = selectedExamDate.Year;
                        examPaper.MailMerge.Execute(new[] { "Ngay_Thi" }, new[] { string.Format("Ngày {0} tháng {1} năm {2}", day, month, year) });

                        // Ghi câu hỏi vào file.
                        StringBuilder questions = new StringBuilder();
                        int i = 1;

                        foreach (var question in pair.Value)
                        {
                            questions.Append($"Câu {i++}: {question.Content}\n");
                            List<Answer> answers = AnswerDao.Instance.GetByQuestionId(question.Id);
                            int j = 65;

                            foreach (var answer in answers)
                            {
                                questions.Append($"{(char)j++}. {answer.Content}\n");
                            }
                            questions.Append("\n");
                        }

                        examPaper.MailMerge.Execute(new[] { "CauHoi" }, new[] { questions.ToString() });

                        // Tạo đường dẫn và lưu.
                        string fileName = "Exam_" + pair.Key.ToString() + ".doc";
                        string filePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), fileName);

                        examPaper.Save(filePath);
                    }

                    // Lưu đề thi vào db.
                    var newExam = new ExamPaper();
                    newExam.SubjectId = (int)CbSubjects.SelectedValue;
                    newExam.ClassId = (int)CbClassRoom.SelectedValue;
                    newExam.ExamDate = DtpExamDate.Value;
                    newExam.Duration = (int)NmDuration.Value;

                    int examPaperId = Convert.ToInt32(ExamPaperDao.Instance.Create(newExam));

                    if (questionData != null && questionData.Count > 0)
                    {
                        foreach (var item in questionData)
                        {
                            ExamPaperDetailsDao.Instance.Create(item.Id, examPaperId);
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Methods.

        private void ShuffleList<T>(List<T> lst)
        {
            int n = lst.Count;

            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1); // [0,n]
                if (n != k)
                {
                    (lst[n], lst[k]) = (lst[k], lst[n]);
                }
            }
        }

        #endregion
    }
}
