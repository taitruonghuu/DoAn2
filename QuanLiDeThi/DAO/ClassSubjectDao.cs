using QuanLiDeThi.Database;
using System;

namespace QuanLiDeThi.DAO
{
    public class ClassSubjectDao
    {
        private static readonly Lazy<ClassSubjectDao> _instanceHolder = new Lazy<ClassSubjectDao>(() => new ClassSubjectDao());

        private ClassSubjectDao() { }

        public static ClassSubjectDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public int AddSubjectToClass(int subjectId, int classId)
        {
            string query = "INSERT INTO ClassSubject (SubjectId, ClassId) VALUES ( @SubjectId , @ClassId )";
            object[] paras = new object[] { subjectId, classId };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int RemoveSubjectByClass(int subjectId, int classId)
        {
            string query = "DELETE ClassSubject WHERE SubjectId = @SubjectId AND ClassId = @ClassId";
            object[] paras = new object[] { subjectId, classId };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int RemoveAllSubjectByClass(int classId)
        {
            string query = "DELETE ClassSubject WHERE ClassId = @ClassId";
            object[] paras = new object[] { classId };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int AddAllSubjectByClass(int classId)
        {
            string query = "INSERT INTO ClassSubject (SubjectId, ClassId) SELECT Id, @ClassId FROM Subject WHERE Id NOT IN (SELECT SubjectId FROM ClassSubject WHERE ClassId = @ClassId )";
            object[] paras = new object[] { classId };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }
    }
}
