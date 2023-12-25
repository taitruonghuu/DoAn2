using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using QuanLiDeThi.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLiDeThi.DAO
{
    public class QuestionDao
    {
        private static readonly Lazy<QuestionDao> _instanceHolder = new Lazy<QuestionDao>(() => new QuestionDao());

        private QuestionDao() { }

        public static QuestionDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public List<Question> GetAllByDifficulty(Difficulty difficulty)
        {
            string query = "SELECT * FROM Question WHERE Difficulty = @Difficulty";
            object[] paras = new object[] { difficulty };
            var questions = DatabaseProvider.Instance.ExecuteQuery(query, paras);
            var data = new List<Question>();

            foreach (DataRow question in questions.Rows)
            {
                data.Add(new Question(question));
            }

            return data;
        }

        public List<Question> GetAll()
        {

            string query = "SELECT * FROM Question";
            var data = new List<Question>();
            var subjects = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow subject in subjects.Rows)
            {
                data.Add(new Question(subject));
            }

            return data;
        }
    }
}
