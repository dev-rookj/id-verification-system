using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace id_verification_system
{
    public static class CourseUtils
    {
        public static string To24Hour(string input)
        {
            if (DateTime.TryParseExact(input.Trim(),
                new[] { "h:mm tt", "hh:mm tt" },
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime dt))
            {
                return dt.ToString("HH:mm");
            }
            throw new FormatException("Invalid time format. Use HH:MM AM/PM.");
        }

        public static bool IsEndAfterStart(string start24, string end24)
        {
            TimeSpan s = TimeSpan.Parse(start24);
            TimeSpan e = TimeSpan.Parse(end24);
            return e > s;
        }

        public static bool IsValidAmPm(string masked)
        {
            if (string.IsNullOrWhiteSpace(masked) || masked.Length < 2) return false;
            string suffix = masked.Substring(masked.Length - 2);
            return suffix == "AM" || suffix == "PM";
        }
    }
}
