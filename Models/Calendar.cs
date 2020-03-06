using System.Runtime.Serialization;

namespace Models
{
    public class Calendar
    {
        /// <summary>
        /// Indicates if arrival and departure times for a stop are strictly adhered to by the vehicle or if they are instead
        /// approximate and/or interpolated times. This field allows a GTFS producer to provide interpolated stop-times, while
        /// indicating that the times are approximate. Valid options are:0 - Times are considered approximate.1 or empty - Times
        /// are considered exact.
        /// </summary>
        [DataMember(Name = "timepoint", IsRequired = false)]
        public string Timepoint { get; set; }

        /// <summary>
        /// Uniquely identifies a set of dates when service is available for one or more routes. Each service_id value can appear
        /// at most once in a calendar.txt file.
        /// </summary>
        [DataMember(Name = "service_id", IsRequired = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the service operates on all Mondays in the date range specified by the start_date and end_date
        /// fields. Note that exceptions for particular dates may be listed in calendar_dates.txt. Valid options are:1 - Service is
        /// available for all Mondays in the date range.0 - Service is not available for Mondays in the date range.
        /// </summary>
        [DataMember(Name = "monday", IsRequired = true)]
        public string Monday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Tuesdays
        /// </summary>
        [DataMember(Name = "tuesday", IsRequired = true)]
        public string Tuesday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Wednesdays
        /// </summary>
        [DataMember(Name = "wednesday", IsRequired = true)]
        public string Wednesday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Thursdays
        /// </summary>
        [DataMember(Name = "thursday", IsRequired = true)]
        public string Thursday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Fridays
        /// </summary>
        [DataMember(Name = "friday", IsRequired = true)]
        public string Friday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Saturdays.
        /// </summary>
        [DataMember(Name = "saturday", IsRequired = true)]
        public string Saturday { get; set; }

        /// <summary>
        /// Functions in the same way as monday except applies to Sundays.
        /// </summary>
        [DataMember(Name = "sunday", IsRequired = true)]
        public string Sunday { get; set; }

        /// <summary>
        /// Start service day for the service interval.
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// End service day for the service interval. This service day is included in the interval.
        /// </summary>
        [DataMember(Name = "end_date", IsRequired = true)]
        public string EndDate { get; set; }
    }
}