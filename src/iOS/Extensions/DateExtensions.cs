using System;
using Firebase.CloudFirestore;
using Foundation;

namespace Plugin.Firebase.iOS.Extensions
{
    public static class DateExtensions
    {
        public static NSDate ToNSDate(this DateTime @this)
        {
            if(@this.Kind == DateTimeKind.Unspecified) {
                @this = DateTime.SpecifyKind(@this, DateTimeKind.Local);
            }
            return (NSDate) @this;
        }
        
        public static NSDate ToNSDate(this DateTimeOffset @this)
        {
            return @this.DateTime.ToNSDate();
        }

        public static DateTimeOffset ToDateTimeOffset(this NSDate @this)
        {
            return DateTime.SpecifyKind(((DateTime) @this), DateTimeKind.Utc);
        }
        
        public static DateTimeOffset ToDateTimeOffset(this Timestamp @this)
        {
            return DateTime.SpecifyKind(((DateTime) @this.DateValue), DateTimeKind.Utc);
        }
    }
}