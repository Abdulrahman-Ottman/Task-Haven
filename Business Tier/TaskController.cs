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
            return clsTask.GetTaskDataById(id);
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
    }
}
