using Common.Enums;
using Common.Types;
using System;

namespace Common.ExtensionMethods
{
    public static class TimeSpanExtension
    {
        public static BlogTimeSpan ToReadable(this TimeSpan span)
        {
            if (span.TotalHours > 0)
            {
                return new BlogTimeSpan
                {
                    Type = TimeUnit.Hour,
                    Value = (int)span.TotalHours
                };
            }
            if (span.TotalMinutes > 0)
            {
                return new BlogTimeSpan
                {
                    Type = TimeUnit.Minute,
                    Value = (int)span.TotalMinutes
                };
            }
            return new BlogTimeSpan
            {
                Type = TimeUnit.Second,
                Value = (int)span.TotalSeconds
            };
        }
    }
}
