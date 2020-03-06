using System.Runtime.Serialization;

namespace Models
{
    public class CalendarDates
    {
        /// <summary>
        /// Identifies a set of dates when a service exception occurs for one or more routes. Each (service_id, date) pair can only
        /// appear once in calendar_dates.txt if using calendar.txt and calendar_dates.txt in conjunction. If a service_id value
        /// appears in both calendar.txt and calendar_dates.txt, the information in calendar_dates.txt modifies the service
        /// information specified in calendar.txt.
        /// </summary>
        [DataMember(Name = "service_id", IsRequired = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Date when service exception occurs.
        /// </summary>
        [DataMember(Name = "date", IsRequired = true)]
        public string Date { get; set; }

        /// <summary>
        /// Indicates whether service is available on the date specified in the date field. Valid options are:
        /// </summary>
        [DataMember(Name = "exception_type", IsRequired = true)]
        public string ExceptionType { get; set; }
    }
}