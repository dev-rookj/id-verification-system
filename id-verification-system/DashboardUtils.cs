using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace id_verification_system
{
    public static class DashboardUtils
    {
        public static (string curClass, string curTime, string curStatus) GetCurrentClass(DateTime now)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"SELECT course_code, course_name, start_time, end_time, major_subject, sched_type
                         FROM courses WHERE day_of_the_week=@Day";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Day", now.DayOfWeek.ToString());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string code = reader.GetString(0);
                            string name = reader.GetString(1);
                            string start24 = reader.GetString(2);
                            string end24 = reader.GetString(3);
                            bool isMajor = reader.GetBoolean(4);
                            string schedType = reader.IsDBNull(5) ? "" : reader.GetString(5);

                            DateTime start = DateTime.ParseExact(start24, "HH:mm", null);
                            DateTime end = DateTime.ParseExact(end24, "HH:mm", null);

                            if (now >= start.AddMinutes(-10) && now <= end)
                            {
                                string indicator = "";
                                if (isMajor && !string.IsNullOrEmpty(schedType))
                                    indicator = schedType.Equals("lecture", StringComparison.OrdinalIgnoreCase) ? "(LEC)" : "(LAB)";

                                string curClass = $"[{code}] {name} {indicator}";
                                string curTime = $"{start:hh\\:mm tt} - {end:hh\\:mm tt}";
                                string curStatus = now < start ? "Up Next" : "Ongoing";

                                return (curClass, curTime, curStatus);
                            }
                        }
                    }
                }
            }
            return ("No class scheduled", "", "");
        }

        public static string LookupStudentName(string studentId)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = "SELECT name FROM students WHERE student_id=@Id";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "Unknown Student";
                }
            }
        }

        public static DateTime ParseStartTime(string curTime)
        {
            string[] parts = curTime.Split('-');
            if (parts.Length > 0)
                return DateTime.Parse(parts[0].Trim());
            return DateTime.Now;
        }
    }
}
