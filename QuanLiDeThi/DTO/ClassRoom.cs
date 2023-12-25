using System.ComponentModel;
using System.Data;

namespace QuanLiDeThi.DTO
{
    public class ClassRoom
    {
        private int id;
        private string name;

        public ClassRoom(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ClassRoom(string name)
        {
            Name = name;
        }

        public ClassRoom(DataRow row)
        {
            Id = (int)row["Id"];
            Name = (string)row["Name"];
        }

        [DisplayName("Mã")]
        public int Id { get { return id; } set { id = value; } }

        [DisplayName("Tên")]
        public string Name { get { return name; } set { name = value; } }
    }
}
