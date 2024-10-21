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
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }

        //CRUD section
        static public bool AddTask(clsTask task)
        {
            if (task == null)
            {
                return false;
            }

            string query = @"INSERT INTO tasks (title, description, end_date, done, created_at)
                             VALUES (@title, @description, @end_date, @done, @created_at)";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);

            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@description", task.Description);
            command.Parameters.AddWithValue("@end_date", task.EndDate);
            command.Parameters.AddWithValue("@done", task.Done);
            command.Parameters.AddWithValue("@created_at", task.CreatedAt);

            return TaskNonQueryCommandExcuter(command);

        }
        static public bool DeleteTasks(string ids)
        {
            if(ids == null || ids == "") return false;

            string query = $"DELETE FROM tasks where id in ({ids})";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);

            return TaskNonQueryCommandExcuter(command);
        }
        static public bool UpdateTask(clsTask task) {
            if (task == null) return false;
            


            string query = @"UPDATE tasks
                           SET [title] = @title
                              ,[description] =  @description
                              ,[end_date] = @end_date
                              ,[done] = @done
                              ,[created_at] = @created_at
                         WHERE id = @id";

            SqlCommand command = new SqlCommand(query, clsSettings.connection);

            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@description", task.Description);
            command.Parameters.AddWithValue("@end_date", task.EndDate);
            command.Parameters.AddWithValue("@done", task.Done);
            command.Parameters.AddWithValue("@created_at", task.CreatedAt);
            command.Parameters.AddWithValue("@id" , task.Id);

            return TaskNonQueryCommandExcuter(command);
        }
        static public bool UpdateTaskStatus(int id, bool status) {

            string query = @"UPDATE tasks
                            set done = @status
                            where id = @id";
            
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@id", id);
            
            return TaskNonQueryCommandExcuter(command);
        }

        //Querys Section
        static public DataTable GetAllTasks()
        {
            string query = "select * from tasks;";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
           
            return TasksQueryCommandExucuter(command);
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
                    task.Title = reader["title"].ToString();
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
        static public DataTable GetTasksByDate(DateTime date) { 
            string query = "Select * from tasks where created_at = @end_date";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
            command.Parameters.AddWithValue ("@end_date", date.Date);

            return TasksQueryCommandExucuter(command);
        }
        static public DataTable GetTasksByStatus(bool status)
        {
            string query = "Select * from tasks where done = @status";
            SqlCommand command = new SqlCommand(query, clsSettings.connection);
            command.Parameters.AddWithValue("@status", status);
           
            return TasksQueryCommandExucuter(command);
        }

        static public DataTable GetTasksByStatusAndDate(bool status, DateTime date) {
            string query = @"Select * from tasks
                             where done = @status and created_at = @date";
            SqlCommand command = new SqlCommand (query, clsSettings.connection);
            command.Parameters.AddWithValue("@status" , status);
            command.Parameters.AddWithValue("@date" , date.Date);
            return TasksQueryCommandExucuter(command);
        }


        //Helper functions section
        static public DataTable GenerateTasksDataTable()
        {
            DataTable tasks = new DataTable();
            tasks.Columns.Add("id", typeof(int));
            tasks.Columns.Add("Done", typeof(bool));
            tasks.Columns.Add("Title", typeof(string));
            tasks.Columns.Add("Description", typeof(string));
            tasks.Columns.Add("End Date", typeof(DateTime));
            tasks.Columns.Add("Created At", typeof(DateTime));
            return tasks;
        }
        static public DataTable TasksQueryCommandExucuter(SqlCommand command)
        {
            DataTable tasks = GenerateTasksDataTable();

            try
            {
                clsSettings.connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tasks.Rows.Add(reader["id"], reader["done"], reader["title"], reader["description"], reader["end_date"], reader["created_at"]);
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
        static public bool TaskNonQueryCommandExcuter(SqlCommand command)
        {
            int rowsAffected = 0;
            try
            {
                clsSettings.connection.Open();

                 rowsAffected = command.ExecuteNonQuery();

    

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsSettings.connection.Close();
            }

            return rowsAffected>0;
        }

    }
}
