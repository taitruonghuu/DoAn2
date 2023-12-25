using QuanLiDeThi.DAO;
using QuanLiDeThi.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiDeThi
{
    public partial class FrmSubject : Form
    {
        private readonly BindingSource subjectList = new BindingSource();

        public FrmSubject()
        {
            InitializeComponent();

            DgvSubjects.DataSource = subjectList;

            SetSubjectListBindingSource();

            AddBinding();
        }

        #region Methods.

        // Sets the data source of the subjectList binding source to the list of subjects retrieved from the database.
        private void SetSubjectListBindingSource()
        {
            subjectList.DataSource = SubjectDao.Instance.GetAll();
        }

        // Adds data bindings between controls and corresponding columns in the data source.
        private void AddBinding()
        {
            TxtSubjectId.DataBindings.Add(new Binding("Text", DgvSubjects.DataSource, "Id", true, DataSourceUpdateMode.Never));
            TxtSubjectName.DataBindings.Add(new Binding("Text", DgvSubjects.DataSource, "Name", true, DataSourceUpdateMode.Never));
            TxtSubjectCode.DataBindings.Add(new Binding("Text", DgvSubjects.DataSource, "Code", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region Events.

        private void BtnLoadSubjects_Click(object sender, EventArgs e)
        {
            SetSubjectListBindingSource();
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = TxtSubjectName.Text.Trim();
            string subjectCode = TxtSubjectCode.Text.Trim();

            if (string.IsNullOrEmpty(subjectName) || string.IsNullOrEmpty(subjectCode))
            {
                MessageBox.Show("Vui lòng nhập vào tên và kí hiệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subject newSubject = new Subject(subjectName, subjectCode);

            if (SubjectDao.Instance.IsSubjectExists(newSubject))
            {
                MessageBox.Show("Môn học đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = SubjectDao.Instance.Create(newSubject);

            if (result > 0)
            {
                SetSubjectListBindingSource();
            }
            else
            {
                 MessageBox.Show("Có lỗi xảy ra khi thêm môn học mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateSubject_Click(object sender, EventArgs e)
        {
            int subjectId = int.Parse(TxtSubjectId.Text);
            string subjectName = TxtSubjectName.Text.Trim();
            string subjectCode = TxtSubjectCode.Text.Trim();
            Subject newSubject = new Subject(subjectId, subjectName, subjectCode);

            int result = SubjectDao.Instance.Update(newSubject);

            if (result > 0)
            {
                SetSubjectListBindingSource();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteSubject_Click(object sender, EventArgs e)
        {
            int subjectId = int.Parse(TxtSubjectId.Text);
            Subject currentSubject = SubjectDao.Instance.GetById(subjectId);
            DialogResult deleteConfirm = MessageBox.Show($"Xác nhận xóa {currentSubject.Name}?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (deleteConfirm == DialogResult.OK)
            {
                int result = SubjectDao.Instance.Delete(subjectId);

                if (result > 0)
                {
                    SetSubjectListBindingSource();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
