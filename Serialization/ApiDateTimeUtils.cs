using System;
using System.Globalization;

namespace KonturEdi.Api.Types.Serialization
{
    public static class ApiDateTimeUtils
    {
        private static readonly string[] apiDateTimeFormats = new []
            {
                "yyyy-MM-ddTHH:mm:ss.ffzzz", 
                "yyyy-MM-dd"
            };

        public static bool TryParse(string dateTimeString, out DateTime result)
        {
            return DateTime.TryParseExact(dateTimeString, apiDateTimeFormats, null, DateTimeStyles.RoundtripKind, out result);
        }

        public static string ToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.ffzzz");
        }
    }
}