using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace id_verification_system
{
    public static class RecordUtils
    {
        public static void SaveRecord(string studentId, string studentName, string courseName, DateTime scanTime, DateTime classStart, Label infoText, Timer infoReset)
        {
            string remarks;
            if (scanTime >= classStart.AddMinutes(-10) && scanTime < classStart.AddMinutes(-5))
                remarks = "Early";
            else if (scanTime >= classStart.AddMinutes(-5) && scanTime < classStart)
                remarks = "Just In Time";
            else
                remarks = "Late";

            string formattedTime = scanTime.ToString("hh:mm tt");

            string cleanCourseName = courseName;
            int closingBracket = cleanCourseName.IndexOf(']');
            if (closingBracket >= 0 && closingBracket + 1 < cleanCourseName.Length)
            {
                cleanCourseName = cleanCourseName.Substring(closingBracket + 1).Trim();
            }

            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"INSERT INTO records (record_date, record_time, student_id, student_name, course_name, remarks)
                     VALUES (@Date, @Time, @StudentId, @StudentName, @CourseName, @Remarks)";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", scanTime.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Time", formattedTime);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@CourseName", cleanCourseName);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);
                    cmd.ExecuteNonQuery();
                }
            }


            infoText.Text = $"Student No.: {studentId}\r\nName: {studentName}\r\n\r\nTime In: {scanTime:hh:mm tt}\r\nRemarks: {remarks}\r\n";
            infoReset.Stop(); // to avoid timer overlapping
            infoReset.Start();
        }
    }
}
