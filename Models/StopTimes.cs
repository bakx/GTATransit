using System.Runtime.Serialization;

namespace Models
{
    public class StopTimes
    {
        /// <summary>
        /// Identifies a trip.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = true)]
        public string TripId { get; set; }

        /// <summary>
        /// Arrival time at a specific stop for a specific trip on a route. If there are not separate times for arrival and
        /// departure at a stop, enter the same value for arrival_time and departure_time. For times occurring after midnight on
        /// the service day, enter the time as a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip
        /// schedule begins.
        /// </summary>
        [DataMember(Name = "arrival_time", IsRequired = false)]
        public string ArrivalTime { get; set; }
    }
}