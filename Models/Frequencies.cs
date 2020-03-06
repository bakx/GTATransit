using System.Runtime.Serialization;

namespace Models
{
    public class Frequencies
    {
        /// <summary>
        /// Identifies a trip to which the specified headway of service applies.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = true)]
        public string TripId { get; set; }

        /// <summary>
        /// Time at which the first vehicle departs from the first stop of the trip with the specified headway.
        /// </summary>
        [DataMember(Name = "start_time", IsRequired = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Time at which service changes to a different headway (or ceases) at the first stop in the trip.
        /// </summary>
        [DataMember(Name = "end_time", IsRequired = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// Time, in seconds, between departures from the same stop (headway) for the trip, during the time interval specified by
        /// start_time and end_time. Multiple headways for the same trip are allowed, but may not overlap. New headways may start
        /// at the exact time the previous headway ends.
        /// </summary>
        [DataMember(Name = "headway_secs", IsRequired = true)]
        public string HeadwaySecs { get; set; }

        /// <summary>
        /// Indicates the type of service for a trip. See the file description for more information. Valid options are:
        /// </summary>
        [DataMember(Name = "exact_times", IsRequired = false)]
        public string ExactTimes { get; set; }
    }
}