using QuanLiDeThi.DAO;
using QuanLiDeThi.DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLiDeThi
{
    public partial class FrmClassRoom : Form
    {
        private readonly BindingSource classRoomList = new BindingSource();

        public FrmClassRoom()
        {
            InitializeComponent();

            DgvClassRoom.DataSource = classRoomList;

            SetClassRoomListBindingSource();

            AddBinding();
        }

        #region Methods.

        private void SetClassRoomListBindingSource()
        {
            classRoomList.DataSource = ClassRoomDao.Instance.GetAll();
        }

        private void AddBinding()
        {
            TxtClassId.DataBindings.Add(new Binding("Text", DgvClassRoom.DataSource, "Id", true, DataSourceUpdateMode.Never));
            TxtClassName.DataBindings.Add(new Binding("Text", DgvClassRoom.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        private void LoadSubjectByClassId(int classId)
        {
            LsvSubjects.Items.Clear();
            List<Subject> subjects = SubjectDao.Instance.GetByClassId(classId);

            foreach (Subject subject in subjects)
            {
                LsvSubjects.Items.Add(subject.Name);
            }
        }

        #endregion

        #region Events.

        private void BtnAddClass_Click(object sender, System.EventArgs e)
        {
            string className = TxtClassName.Text.Trim();

            if (string.IsNullOrEmpty(className) )
            {
                MessageBox.Show("Tên lớp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassRoom room = new ClassRoom(className);

            if (ClassRoomDao.Instance.IsClassRoomExists(room))
            {
                MessageBox.Show("Lớp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = ClassRoomDao.Instance.Create(room);

            if (result > 0)
            {
                SetClassRoomListBindingSource();
            } else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm lớp học mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateClass_Click(object sender, System.EventArgs e)
        {
            int classId = int.Parse(TxtClassId.Text);
            string className = TxtClassName.Text.Trim();
            ClassRoom room = new ClassRoom(classId, className);

            int result = ClassRoomDao.Instance.Update(room);

            if (result > 0)
            {
                SetClassRoomListBindingSource();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteClass_Click(object sender, System.EventArgs e)
        {
            int classId = int.Parse(TxtClassId.Text);
            ClassRoom currentClass = ClassRoomDao.Instance.GetById(classId);
            DialogResult deleteConfirm = MessageBox.Show($"Xác nhận xóa {currentClass.Name}?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        
            if (deleteConfirm == DialogResult.OK)
            {
                int result = ClassRoomDao.Instance.Delete(classId);

                if (result > 0)
                {
                    SetClassRoomListBindingSource();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLoadClass_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(TxtClassId.Text, out int currentClassId))
            {
                LoadSubjectByClassId(currentClassId);
            }
            else
            {
                LsvSubjects.Items.Clear();
            }
        }

        private void TxtClassId_TextChanged(object sender, System.EventArgs e)
        {
            if (sender is TextBox txtClassId)
            {
                if (int.TryParse(txtClassId.Text, out int currentClassId))
                {
                    LoadSubjectByClassId(currentClassId);

                } else
                {
                    LsvSubjects.Items.Clear();
                }
            }
        }

        private void BtnEditSubjectsByClassId_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(TxtClassId.Text, out int currentClassId))
            {
                FrmManageClassSubject frmManageClassSubject = new FrmManageClassSubject(currentClassId);
                Hide();
                frmManageClassSubject.ShowDialog();
                LoadSubjectByClassId(currentClassId);
                Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn lớp học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
