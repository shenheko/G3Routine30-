using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using System.Data.SQLite;

public class TasksDatabaseHelper
{
    private string connectionString;

    public TasksDatabaseHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Fetch all tasks for a specific user
    public DataTable GetTasks(int userId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "SELECT * FROM Tasks WHERE UserId = @UserId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    // Mark a task as complete
    public void MarkTaskAsComplete(int taskId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "UPDATE Tasks SET IsComplete = 1 WHERE TaskId = @TaskId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@TaskId", taskId);
                cmd.ExecuteNonQuery();
            }
        }
    }



    // Add a new task
    public void AddTask(string taskName, int userId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "INSERT INTO Tasks (TaskName, UserId, IsComplete) VALUES (@TaskName, @UserId, 0)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@TaskName", taskName);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

