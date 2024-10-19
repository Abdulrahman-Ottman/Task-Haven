using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Tier
{
    public class clsTask
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }

        static public bool AddTask(clsTask task)
        {
            if (task == null)
            {
                return false;
            }

            bool added = false;


            string query = @"INSERT INTO tasks (name, description, end_date, done, created_at)
                             VALUES (@name, @description, @end_date, @done, @created_at)";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);

            command.Parameters.AddWithValue("@name", task.Name);
            command.Parameters.AddWithValue("@description", task.Description);
            command.Parameters.AddWithValue("@end_date", task.EndDate);
            command.Parameters.AddWithValue("@done", task.Done);
            command.Parameters.AddWithValue("@created_at", task.CreatedAt);

            try
            {
                clsSettings.connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    added = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsSettings.connection.Close();
            }

            return added;

        }

        static public DataTable GetAllTasks()
        {
            DataTable tasks = new DataTable();

            string query = "select * from tasks;";
            


            return tasks;
        }
    }
}
