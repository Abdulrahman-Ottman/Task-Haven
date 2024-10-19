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
        static public bool AddTask(string name , string description , DateTime end_date , DateTime created_at )
        {
            clsTask task = new clsTask();
            task.Name = name;
            task.Description = description; 
            task.EndDate = end_date;
            task.CreatedAt = created_at;
            return clsTask.AddTask(task);
        }
        static public DataTable GetAllTasks()
        {
            return clsTask.GetAllTasks();
        }
    }
}
