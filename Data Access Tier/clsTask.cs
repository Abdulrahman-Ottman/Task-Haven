using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
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
            tasks.Columns.Add("id", typeof(int));
            tasks.Columns.Add("Done", typeof(bool));
            tasks.Columns.Add("Name", typeof(string));
            tasks.Columns.Add("Description", typeof(string));
            tasks.Columns.Add("End Date", typeof(DateTime));
            tasks.Columns.Add("Created At", typeof(DateTime));


            string query = "select * from tasks;";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
            try
            {
                clsSettings.connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    tasks.Rows.Add(reader["id"] ,reader["done"] , reader["name"] , reader["description"] , reader["end_date"] , reader["created_at"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsSettings.connection.Close();
            }


            return tasks;
        }

        static public Dictionary<string, string> GetTaskDataById(int id) {
            Dictionary<string , string> taskData = new Dictionary<string , string>();
            string query = "select * from tasks where id = @id";
            SqlCommand command = new SqlCommand(query , clsSettings.connection);
            command.Parameters.AddWithValue("@id" , id);

            try
            {
                clsSettings.connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taskData.Add("id" , reader["id"].ToString());
                    taskData.Add("name" , reader["name"].ToString());
                    taskData.Add("description" , reader["description"].ToString());
                    taskData.Add("done" , reader["done"].ToString());
                    taskData.Add("end_date" , reader["end_date"].ToString());
                    taskData.Add("created_at" , reader["created_at"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                clsSettings.connection.Close();
            }
            return taskData;
        }

        static public clsTask FindTaskByID(int id) {
            clsTask task = new clsTask();

            string query = "select * from tasks where id = @id";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                clsSettings.connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    task.Id = id;
                    task.Name = reader["name"].ToString();
                    task.Description = reader["description"].ToString();
                    task.EndDate = DateTime.Parse(reader["end_date"].ToString());
                    task.Done = (bool)(reader["done"]);
                    task.CreatedAt = DateTime.Parse(reader["created_at"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsSettings.connection.Close();
            }
            return task;
        }

        static public bool UpdateTask(clsTask task) {
            if (task == null)
            {
                return false;
            }

            bool updated = false;


            string query = @"UPDATE tasks
                           SET [name] = @name
                              ,[description] =  @description
                              ,[end_date] = @end_date
                              ,[done] = @done
                              ,[created_at] = @created_at
                         WHERE id = @id";

            SqlCommand command = new SqlCommand(query, clsSettings.connection);

            command.Parameters.AddWithValue("@name", task.Name);
            command.Parameters.AddWithValue("@description", task.Description);
            command.Parameters.AddWithValue("@end_date", task.EndDate);
            command.Parameters.AddWithValue("@done", task.Done);
            command.Parameters.AddWithValue("@created_at", task.CreatedAt);
            command.Parameters.AddWithValue("@id" , task.Id);

            try
            {
                clsSettings.connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    updated = true;
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

            return updated;
        }

    }
}
