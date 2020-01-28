using System;
using System.Globalization;

namespace SkbKontur.EdiApi.Types.Serialization
{
    public static class DateTimeUtils
    {
        public static bool TryParse(string dateTimeString, out DateTime result)
        {
            return DateTime.TryParseExact(dateTimeString, apiDateTimeFormats, null, DateTimeStyles.RoundtripKind, out result);
        }

        public static string ToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.ffzzz");
        }

        private static readonly string[] apiDateTimeFormats = new[]
            {
                "yyyy-MM-ddTHH:mm:ss.ffzzz",
                "yyyy-MM-dd"
            };
    }
}