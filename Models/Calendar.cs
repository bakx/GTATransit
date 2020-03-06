using System.Runtime.Serialization;

namespace Models
{
    public class Calendar
    {
        /// <summary>
        /// Uniquely identifies a set of dates when service is available for one or more routes. Each service_id value can appear
        /// at most once in a calendar.txt file.
        /// </summary>
        [DataMember(Name = "service_id", IsRequired = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Mondays in the date range specified by the start_date and end_date
        /// fields. Note that exceptions for particular dates may be listed in calendar_dates.txt. Valid options are:
        /// </summary>
        [DataMember(Name = "monday", IsRequired = true)]
        public string Monday { get; set; }
    }
}