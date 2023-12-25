using QuanLiDeThi.DAO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using QuanLiDeThi.Database;

namespace QuanLiDeThi
{
    public partial class FrmExamInput : Form
    {
        private string filePath = string.Empty;

        public FrmExamInput()
        {
            InitializeComponent();
        }

        #region Events.

        private void FrmExamInput_Load(object sender, EventArgs e)
        {
            CbSubjects.DataSource = SubjectDao.Instance.GetAll();
            CbSubjects.ValueMember = "Id";
            CbSubjects.DisplayMember = "Name";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmExamInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Bạn có chắc chắn muốn dừng việc thêm đề thi?", @"Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp tin Word|*.doc;*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                TxtShowFilePath.Text = filePath;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int selectedSubjectId = (int)CbSubjects.SelectedValue;
            string selectedSubjectName = CbSubjects.Text;
            DialogResult confirmSaveFile = MessageBox.Show($"Xác nhận lưu đề thi sau theo môn học '{selectedSubjectName}' không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmSaveFile == DialogResult.Cancel) return;

            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                {
                    // Trich xuat toan bo noi dung tu file word.
                    StringBuilder sb = new StringBuilder();
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    foreach (Paragraph paragraph in body.Elements<Paragraph>())
                    {
                        sb.Append(paragraph.InnerText);
                    }

                    string content = sb.ToString();

                    // Tach cau hoi va dap an va luu vao ctdl Map.
                    string pattern = @"(<@\s*(.*?)\s*@>|<!\s*(.*?)\s*!>)";
                    MatchCollection matches = Regex.Matches(content, pattern);
                    List<string> elements = new List<string>();

                    foreach (Match match in matches)
                    {
                        elements.Add(match.Value);
                    }

                    var qAPairs = new Dictionary<string, List<string>>();
                    string currentQuestion = string.Empty;

                    foreach (string element in elements)
                    {
                        if (element.StartsWith("<@") && element.EndsWith("@>"))
                        {
                            currentQuestion = Regex.Replace(element, @"<@|@>", "").Trim();
                            qAPairs[currentQuestion] = new List<string>();
                        }
                        else if (element.StartsWith("<!") && element.EndsWith("!>"))
                        {
                            qAPairs[currentQuestion].Add(Regex.Replace(element, @"<!|!>", "").Trim());
                        }
                    }

                    // Luu cau hoi va dap an vao database.
                    foreach (var pair in qAPairs)
                    {
                        string question = pair.Key;
                        List<string> answers = pair.Value;

                        // Them cau hoi vao db.
                        string questionInsertQuery = "INSERT INTO Question (Id, SubjectId, Content, Difficulty) VALUES ( @Id , @SubjectId , @Content , @Difficulty )";
                        Guid questionId = Guid.NewGuid();
                        int questionDifficulty = 0; // ^ easy, # medium, * hard.

                        switch (question[0])
                        {
                            case '^':
                                questionDifficulty = 0;
                                break;
                            case '#':
                                questionDifficulty = 1;
                                break;
                            case '*':
                                questionDifficulty = 2;
                                break;
                            default:
                                MessageBox.Show($"Không thể xác định được độ khó của câu hỏi: {question.Substring(1)}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                        }

                        question = question.Substring(1);
                        int resultInsertQuestionQuery = DatabaseProvider.Instance.ExecuteNonQuery(
                            questionInsertQuery,
                            new object[] { questionId, selectedSubjectId, question, questionDifficulty }
                        );

                        // Them cau tra loi vao db.
                        if (resultInsertQuestionQuery > 0 )
                        {
                            string answerInsertQuery = $"INSERT INTO Answer (QuestionId, Content, IsCorrect) VALUES ( @QuestionId , @Content , @IsCorrect )";
                            foreach (var item in answers)
                            {
                                bool isCorrectAnswer = false;
                                string answer = item;

                                if (item.StartsWith("*"))
                                {
                                    answer = item.Substring(1);
                                    isCorrectAnswer = true;
                                }

                                int resultInsertAnswerQuery = DatabaseProvider.Instance.ExecuteNonQuery(
                                    answerInsertQuery,
                                    new object[] { questionId, answer, isCorrectAnswer }
                                );

                                if (resultInsertAnswerQuery <= 0 )
                                {
                                    MessageBox.Show($"Có lỗi xả ra khi thêm câu trả lời {answer}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        } else
                        {
                            MessageBox.Show($"Có lỗi xả ra khi thêm câu hỏi {question}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show(@"File đang được sử dụng bởi một ứng dụng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
