using QuanLiDeThi.Enums;
using System;
using System.Data;

namespace QuanLiDeThi.DTO
{
    public class Question
    {
        private Guid id;
        private string content;
        private Difficulty difficulty;
        private int subjectId;

        public Question(DataRow row)
        {
            Id = (Guid)row["Id"];
            Content = (string)row["Content"];
            Difficulty = (Difficulty)row["Difficulty"];
            SubjectId = (int) row["SubjectId"];
        }

        public Guid Id { 
            get { return id; } 
            set { id = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public Difficulty Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public int SubjectId
        {
            get { return subjectId; }
            set { subjectId = value; }
        }
    }
}
