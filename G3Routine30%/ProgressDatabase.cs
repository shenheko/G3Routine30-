using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

public class DatabaseHelper
{
    private string connectionString = @"Data Source=users.db;Version=3;";

    // Add a main task to the ProgressTracker table.
    public void AddMainTask(string mainTaskName, int userId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "INSERT INTO ProgressTracker (MainTaskName, UserId) VALUES (@MainTaskName, @UserId)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@MainTaskName", mainTaskName);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Add a subtask to an existing main task in the ProgressTracker table.
    public void AddSubTask(string subTaskName, int parentTrackerId, int userId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "INSERT INTO ProgressTracker (MainTaskName, SubTaskName, UserId, ParentTrackerId) " +
                           "VALUES (@MainTaskName, @SubTaskName, @UserId, @ParentTrackerId)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@MainTaskName", subTaskName); // Subtasks don't need unique MainTaskName
                cmd.Parameters.AddWithValue("@SubTaskName", subTaskName);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@ParentTrackerId", parentTrackerId);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Mark a task (main or subtask) as complete in the ProgressTracker table.
    public void MarkProgressTaskAsComplete(int trackerId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "UPDATE ProgressTracker SET IsComplete = 1 WHERE TrackerId = @TrackerId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@TrackerId", trackerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
    public void MarkTaskAsComplete(int taskId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();

            string query = "UPDATE Tasks SET IsComplete = 1 WHERE TaskId = @TaskId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@TaskId", taskId);
                cmd.ExecuteNonQuery(); // Executes the update query
            }
        }
    }

    // Fetch main tasks for a user.
    public DataTable GetMainTasks(int userId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "SELECT * FROM ProgressTracker WHERE ParentTrackerId IS NULL AND UserId = @UserId";

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

    // Fetch subtasks for a specific main task.
    public DataTable GetSubTasks(int parentTrackerId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = "SELECT * FROM ProgressTracker WHERE ParentTrackerId = @ParentTrackerId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@ParentTrackerId", parentTrackerId);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    // Calculate the percentage of completion for a main task.
    public double GetCompletionPercentage(int mainTaskId)
    {
        using (SQLiteConnection sqlCon = new SQLiteConnection(connectionString))
        {
            sqlCon.Open();
            string query = @"
                SELECT 
                    SUM(CASE WHEN IsComplete = 1 THEN 1 ELSE 0 END) * 1.0 / COUNT(*) * 100 AS CompletionPercentage
                FROM ProgressTracker
                WHERE ParentTrackerId = @MainTaskId OR TrackerId = @MainTaskId";

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlCon))
            {
                cmd.Parameters.AddWithValue("@MainTaskId", mainTaskId);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDouble(result) : 0;
            }
        }
    }
}
