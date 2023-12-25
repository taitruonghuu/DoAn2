using DocumentFormat.OpenXml.VariantTypes;
using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLiDeThi.DAO
{
    public class AnswerDao
    {
        private static readonly Lazy<AnswerDao> _instanceHolder = new Lazy<AnswerDao>(() => new AnswerDao());

        private AnswerDao() { }

        public static AnswerDao Instance { 
            get {  return _instanceHolder.Value; } 
            private set { }
        }

        public List<Answer> GetByQuestionId(Guid questionId)
        {
            string query = "SELECT * FROM Answer WHERE QuestionId = @QuestionId";
            object[] paras = new object[] { questionId };
            var data = new List<Answer>();
            var subjects = DatabaseProvider.Instance.ExecuteQuery(query, paras);

            foreach (DataRow subject in subjects.Rows)
            {
                data.Add(new Answer(subject));
            }

            return data;
        }
    }
}
