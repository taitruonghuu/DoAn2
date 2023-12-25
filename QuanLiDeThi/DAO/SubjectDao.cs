using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLiDeThi.DAO
{
    public class SubjectDao
    {
        private static readonly Lazy<SubjectDao> _instanceHolder = new Lazy<SubjectDao>(() => new SubjectDao());

        private SubjectDao() { }

        public static SubjectDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public List<Subject> GetByClassId(int classId)
        {
            string query = "SELECT s.Id, s.Name, s.Code FROM Subject as s JOIN ClassSubject as c ON s.Id = c.SubjectId WHERE c.ClassId = @ClassId";
            object[] paras = new object[] { classId };
            var data = new List<Subject>();
            var subjects = DatabaseProvider.Instance.ExecuteQuery(query, paras);

            foreach (DataRow subject in subjects.Rows)
            {
                data.Add(new Subject(subject));
            }

            return data;
        }

        public List<Subject> GetNonClassSubjectsByClassId(int classId)
        {
            string query = "SELECT s.* FROM Subject as s LEFT JOIN ClassSubject as c ON s.Id = c.SubjectId AND c.ClassId = @ClassId WHERE c.SubjectId IS NULL";
            object[] paras = new object[] { classId };
            var data = new List<Subject>();
            var subjects = DatabaseProvider.Instance.ExecuteQuery(query, paras);

            foreach (DataRow subject in subjects.Rows)
            {
                data.Add(new Subject(subject));
            }

            return data;
        }

        public List<Subject> GetAll()
        {
            string query = "SELECT Id, Name, Code FROM Subject";
            var data = new List<Subject>();
            var subjects = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow subject in subjects.Rows)
            {
                data.Add(new Subject(subject));
            }

            return data;
        }

        public Subject GetById(int id)
        {
            string query = "SELECT * FROM Subject WHERE Id = @Id";
            object[] paras = new object[] { id };
            DataTable subjects = DatabaseProvider.Instance.ExecuteQuery(query, paras);
            DataRow row = subjects.Rows[0];

            return new Subject(row);
        }

        public bool IsSubjectExists(Subject subject)
        {
            string query = "SELECT COUNT(*) FROM Subject WHERE Name = @Name OR Code = @Code";
            object[] paras = new object[] { subject.Name, subject.Code };
            int existingRecordsCount = (int)DatabaseProvider.Instance.ExecuteScalar(query, paras);

            return existingRecordsCount > 0;
        }

        public int Create(Subject subject)
        {
            string query = "INSERT INTO Subject (Name, Code) VALUES ( @Name , @Code )";
            object[] paras = new object[] { subject.Name, subject.Code };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int Update(Subject subject)
        {
            string query = "UPDATE Subject SET Name = @Name , Code = @Code WHERE Id = @Id";
            object[] paras = new object[] { subject.Name, subject.Code, subject.Id };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int Delete(int id)
        {
            string query = "DELETE Subject WHERE Id = @Id";
            object[] paras = new object[] { id };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }
    }
}
