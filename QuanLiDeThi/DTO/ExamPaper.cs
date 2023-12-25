using System;
using System.Data;

namespace QuanLiDeThi.DTO
{
    public class ExamPaper
    {
        private int id;
        private int subjectId;
        private int classId;
        private DateTime releaseDate;
        private DateTime examDate;
        private int duration;

        public ExamPaper() { }

        public ExamPaper(DataRow row)
        {
            Id = (int)row["Id"];
            SubjectId = (int)row["SubjectId"];
            ClassId = (int)row["ClassId"];
            ReleaseDate = (DateTime)row["ReleaseDate"];
            ExamDate = (DateTime)row["ExamDate"];
            Duration = (int)row["Duration"];
        }

        public int Id { get { return id; } set {  id = value; } }
        public int SubjectId { get {  return subjectId; } set {  subjectId = value; } }
        public int ClassId { get { return classId; } set {  classId = value; } }
        public DateTime ReleaseDate { get {  return releaseDate; } set {  releaseDate = value; } }
        public DateTime ExamDate { get { return examDate; } set {  examDate = value; } }
        public int Duration { get { return duration; } set { duration = value; } }
    }
}
