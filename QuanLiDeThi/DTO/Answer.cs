using System.Data;

namespace QuanLiDeThi.DTO
{
    public class Answer
    {
        private int id;
        private string content;
        private bool isCorrect;

        public Answer(DataRow row)
        {
            Id = (int)row["Id"];
            Content = (string)row["Content"];
            isCorrect = (bool)row["IsCorrect"];
        }

        public int Id { get { return id; } set { id = value; } }

        public string Content { get { return content; } set { content = value; } }

        public bool IsCorrect { get { return isCorrect; } set { isCorrect = value; } }
    }
}
