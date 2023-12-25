using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using System;

namespace QuanLiDeThi.DAO
{
    public class ExamPaperDetailsDao
    {
        private static readonly Lazy<ExamPaperDetailsDao> _instanceHolder = new Lazy<ExamPaperDetailsDao>(() => new ExamPaperDetailsDao());

        private ExamPaperDetailsDao() { }

        public static ExamPaperDetailsDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public int Create(Guid questionId, int examPaperId)
        {
            string query = "INSERT INTO ExamPaperDetail (QuestionId, ExamPaperId) VALUES ( @QuestionId , @ExamPaperId )";
            object[] paras = new object[] { questionId, examPaperId };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }
    }
}
