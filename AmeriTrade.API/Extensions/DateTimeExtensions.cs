using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriTrade.API.Extensions
{
    public static class DateTimeExtensions
    {
        private static readonly TimeZoneInfo ServerTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        public static DateTime ToServerTime(this DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTime(dateTime, ServerTimeZone);
        }
    }
}
