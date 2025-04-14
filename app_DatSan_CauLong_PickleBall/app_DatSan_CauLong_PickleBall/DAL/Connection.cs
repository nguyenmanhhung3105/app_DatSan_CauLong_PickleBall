using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
namespace DAL
{
    internal class Connection
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        private static readonly string connectionString = @"Data Source=LAPTOP-KO4RO541\SQLEXPRESS;Initial Catalog=QuanLySan;Integrated Security=True;";
        private static SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static int actionQuery(string sql, Dictionary<string, object> parameters = null) {
            int count = 0;
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                if (!string.IsNullOrEmpty(param.Key) && param.Value != null)
                                {
                                    command.Parameters.Add(new SqlParameter(param.Key, param.Value));
                                }
                            }
                        }
                        count = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                LogException(ex);
            }
            return count;
        }
        public static DataTable selectQuery(string sql, Dictionary<string, object> parameters = null)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = getConnection())
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Nếu có tham số, thêm vào câu lệnh SQL
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                if (!string.IsNullOrEmpty(param.Key) && param.Value != null)
                                {
                                    command.Parameters.Add(new SqlParameter(param.Key, param.Value));
                                }
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }

            return table;
        }

        public static int cntQuery(string sql, Dictionary<string, object> parameters = null) {
            using (SqlConnection connection = getConnection()) {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
        private static void LogException(Exception ex)
        {
            Console.WriteLine("❌ Lỗi: " + ex.Message);
            Console.WriteLine("→ Lớp: " + ex.TargetSite.DeclaringType);
            Console.WriteLine("→ Phương thức: " + ex.TargetSite.Name);
            Console.WriteLine("→ Stack Trace:\n" + ex.StackTrace);
        }
    }
}
