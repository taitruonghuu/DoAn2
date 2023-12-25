using QuanLiDeThi.DAO;
using QuanLiDeThi.DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLiDeThi
{
    public partial class FrmManageClassSubject : Form
    {
        private int classId;
        private ClassRoom currentClass;
        private List<Subject> selectedSubjects;
        private List<Subject> remainingSubjects;

        public FrmManageClassSubject(int classId)
        {
            InitializeComponent();
            ClassId = classId;
        }

        public int ClassId { get { return classId; } set { classId = value; } }

        #region Methods.

        private void LoadSubjects()
        {
            selectedSubjects = SubjectDao.Instance.GetByClassId(ClassId);
            remainingSubjects = SubjectDao.Instance.GetNonClassSubjectsByClassId(ClassId);

            ShowSubjectList(LsvSelectedSubjects, selectedSubjects);
            ShowSubjectList(LsvRemainingSubjects, remainingSubjects);
        }

        private void ShowSubjectList(System.Windows.Forms.ListView lsv, List<Subject> subjects)
        {
            lsv.Clear();

            foreach (Subject subject in subjects)
            {
                ListViewItem item = new ListViewItem(subject.Name);
                item.Tag = subject.Id;
                lsv.Items.Add(item);
            }
        }

        #endregion

        #region Events.

        private void FrmManageClassSubject_Load(object sender, System.EventArgs e)
        {
            currentClass = ClassRoomDao.Instance.GetById(ClassId);
            LoadSubjects();
        }

        private void BtnAddOne_Click(object sender, System.EventArgs e)
        {
            if (LsvRemainingSubjects.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = LsvRemainingSubjects.SelectedItems[0];
                int subjectId = (int)selectedItem.Tag;
                int result = ClassSubjectDao.Instance.AddSubjectToClass(subjectId, classId);

                if (result > 0)
                {
                    LoadSubjects();
                } else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm môn học vào lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Bạn chưa chọn môn học nào để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRemoveOne_Click(object sender, System.EventArgs e)
        {
            if (LsvSelectedSubjects.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = LsvSelectedSubjects.SelectedItems[0];
                int subjectId = (int)selectedItem.Tag;
                int result = ClassSubjectDao.Instance.RemoveSubjectByClass(subjectId, classId);

                if (result > 0)
                {
                    LoadSubjects();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa môn học khỏi lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn học nào để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRemoveAll_Click(object sender, System.EventArgs e)
        {
            int result = ClassSubjectDao.Instance.RemoveAllSubjectByClass(classId);

            if (result > 0)
            {
                LoadSubjects();
            } else
            {
                MessageBox.Show($"Lớp {currentClass.Name} chưa có môn học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddAll_Click(object sender, System.EventArgs e)
        {
            int result = ClassSubjectDao.Instance.AddAllSubjectByClass(classId);

            if (result > 0)
            {
                LoadSubjects();
            } else
            {
                MessageBox.Show($"Lớp {currentClass.Name} đã chứa tất cả môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
