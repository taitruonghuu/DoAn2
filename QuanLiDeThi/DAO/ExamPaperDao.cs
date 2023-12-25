using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using System;

namespace QuanLiDeThi.DAO
{
    public class ExamPaperDao
    {
        private static readonly Lazy<ExamPaperDao> _instanceHolder = new Lazy<ExamPaperDao>(() => new ExamPaperDao());
    
        private ExamPaperDao() { }

        public static ExamPaperDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public object Create(ExamPaper examPaper)
        {
            string query = "INSERT INTO ExamPaper (SubjectId, ClassId, ExamDate, Duration) VALUES ( @SubjectId , @ClassId , @ExamDate , @Duration ); SELECT SCOPE_IDENTITY();";
            object[] paras = new object[] { examPaper.SubjectId, examPaper.ClassId, examPaper.ExamDate, examPaper.Duration };

            return DatabaseProvider.Instance.ExecuteScalar(query, paras);
        }
    }
}
