using System.Data.SqlClient;
using System.Data;
using System;

namespace QuanLiDeThi.Database
{
    public class DatabaseProvider
    {
        private static readonly Lazy<DatabaseProvider> _instanceHolder = new Lazy<DatabaseProvider>(() => new DatabaseProvider());
        private readonly string ConnectionString = "Data Source=(local);Initial Catalog=QuanLiDeThi;Integrated Security=True";

        private DatabaseProvider() { }

        public static DatabaseProvider Instance
        {
            get { return _instanceHolder.Value; }
            private set { }
        }

        /// <summary>
        /// Executes a SQL query and returns the result as a DataTable.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters to be used in the query.</param>
        /// <returns>A DataTable containing the result of the query.</returns>
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        string[] paraKeys = query.Split(' ');
                        int i = 0;

                        foreach (string item in paraKeys)
                        {
                            if (item.Contains("@"))
                            {
                                if (!command.Parameters.Contains(item))
                                {
                                    command.Parameters.AddWithValue(item, parameters[i]);
                                    i++;
                                }   
                            }
                        }
                    }

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Executes a non-query SQL statement and returns the number of affected rows.
        /// </summary>
        /// <param name="query">The SQL statement to execute.</param>
        /// <param name="parameters">Optional parameters to be used in the statement.</param>
        /// <returns>The number of rows affected by the SQL statement.</returns>
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int result = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        string[] paraKeys = query.Split(' ');
                        int i = 0;

                        foreach (string item in paraKeys)
                        {
                            if (item.Contains("@"))
                            {
                                if (!command.Parameters.Contains(item))
                                {
                                    command.Parameters.AddWithValue(item, parameters[i]);
                                    i++;
                                }
                            }
                        }
                    }

                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        /// <summary>
        /// Executes the specified SQL query and returns the first column of the first row in the result set.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters to be used in the query.</param>
        /// <returns>The value of the first column of the first row in the result set.</returns>
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        string[] paraKeys = query.Split(' ');
                        int i = 0;

                        foreach (string item in paraKeys)
                        {
                            if (item.Contains("@"))
                            {
                                if (!command.Parameters.Contains(item))
                                {
                                    command.Parameters.AddWithValue(item, parameters[i]);
                                    i++;
                                }
                            }
                        }
                    }

                    result = command.ExecuteScalar();
                }
            }

            return result;
        }
    }
}
