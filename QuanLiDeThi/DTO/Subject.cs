using System.ComponentModel;
using System.Data;

namespace QuanLiDeThi.DTO
{
    public class Subject
    {
        private int id;
        private string name;
        private string code;

        public Subject(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;
        }

        public Subject(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public Subject(DataRow row)
        {
            Id = (int)row["Id"];
            Name = (string)row["Name"];
            Code = (string)row["Code"];
        }

        [DisplayName("Mã")]
        public int Id { get { return id; } set { id = value; } }

        [DisplayName("Tên")]
        public string Name { get { return name; } set { name = value; } }

        [DisplayName("Kí hiệu")]
        public string Code { get { return code; } set { code = value; } }
    }
}
