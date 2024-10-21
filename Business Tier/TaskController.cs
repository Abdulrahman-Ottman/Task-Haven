using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Data_Access_Tier;
namespace Business_Tier
{
    public class TaskController
    {
        static public bool AddTask(string title , string description , DateTime end_date , DateTime created_at )
        {
            clsTask task = new clsTask();
            task.Title = title;
            task.Description = description; 
            task.EndDate = end_date;
            task.CreatedAt = created_at;
            return clsTask.AddTask(task);
        }
        static public DataTable GetAllTasks()
        {
            return clsTask.GetAllTasks();
        }

        public static Dictionary<string , string> GetTaskDataById(int id)
        {
            Dictionary<string, string> taskData = new Dictionary<string, string>();
            clsTask task = clsTask.FindTaskByID(id);
            taskData.Add("id", task.Id.ToString());
            taskData.Add("title", task.Title);
            taskData.Add("description", task.Description);
            taskData.Add("done", task.Done.ToString());
            taskData.Add("end_date", task.EndDate.ToString());
            taskData.Add("created_at", task.CreatedAt.ToString());
            return taskData;
        }

        public static bool UpdateTask(int id , string title, string description, DateTime end_date, DateTime created_at)
        {
            clsTask task = clsTask.FindTaskByID(id);
            task.Title = title;
            task.Description = description;
            task.EndDate = end_date;
            task.CreatedAt = created_at;
            return clsTask.UpdateTask(task);
        }

        public static bool DeleteTasks(int id) {
           
            return clsTask.DeleteTasks(id.ToString());
        }

        public static bool UpdateTaskStatus(int id, bool status){
            return clsTask.UpdateTaskStatus(id,status);
        }

        public static DataTable GetTasksByDate(DateTime date) {
            return clsTask.GetTasksByDate(date);
        }

        public static DataTable GetTasksByStatus(bool status)
        {
            return clsTask.GetTasksByStatus(status);
        }

        public static DataTable GetTasksByStatusAndDate(bool status , DateTime date)
        {
            return clsTask.GetTasksByStatusAndDate(status , date);
        }
    }
}
