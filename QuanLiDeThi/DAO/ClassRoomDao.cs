using QuanLiDeThi.Database;
using QuanLiDeThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLiDeThi.DAO
{
    public class ClassRoomDao
    {
        private static readonly Lazy<ClassRoomDao> _instanceHolder = new Lazy<ClassRoomDao>(() => new ClassRoomDao());

        private ClassRoomDao() { }

        public static ClassRoomDao Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        public List<ClassRoom> GetAll()
        {
            string query = "SELECT * FROM ClassRoom";
            var data = new List<ClassRoom>();
            var classRooms = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow classRoom in classRooms.Rows)
            {
                data.Add(new ClassRoom(classRoom));
            }

            return data;
        }

        public ClassRoom GetById(int id)
        {
            string query = "SELECT * FROM ClassRoom WHERE Id = @Id";
            object[] paras = new object[] { id };
            DataTable subjects = DatabaseProvider.Instance.ExecuteQuery(query, paras);
            DataRow row = subjects.Rows[0];

            return new ClassRoom(row);
        }

        public bool IsClassRoomExists(ClassRoom room)
        {
            string query = "SELECT COUNT(*) FROM ClassRoom WHERE Name = @Name";
            object[] paras = new object[] { room.Name };
            int existingRecordsCount = (int) DatabaseProvider.Instance.ExecuteScalar(query, paras);

            return existingRecordsCount > 0;
        }

        public int Create(ClassRoom room)
        {
            string query = "INSERT INTO ClassRoom (Name) VALUES ( @Name )";
            object[] paras = new object[] { room.Name };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int Update(ClassRoom room)
        {
            string query = "UPDATE ClassRoom SET Name = @Name WHERE Id = @Id";
            object[] paras = new object[] { room.Name, room.Id };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public int Delete(int id)
        {
            string query = "DELETE ClassRoom WHERE Id = @Id";
            object[] paras = new object[] { id };

            return DatabaseProvider.Instance.ExecuteNonQuery(query, paras);
        }
    }
}
