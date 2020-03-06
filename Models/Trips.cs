using System.Runtime.Serialization;

namespace Models
{
    public class Trips
    {
        /// <summary>
        /// Identifies a route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = true)]
        public string RouteId { get; set; }

        /// <summary>
        /// Identifies a set of dates when service is available for one or more routes.
        /// </summary>
        [DataMember(Name = "service_id", IsRequired = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Identifies a trip.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = true)]
        public string TripId { get; set; }

        /// <summary>
        /// Text that appears on signage identifying the trip's destination to riders. Use this field to distinguish between
        /// different patterns of service on the same route. If the headsign changes during a trip, trip_headsign can be overridden
        /// by specifying values for the stop_times.stop_headsign.
        /// </summary>
        [DataMember(Name = "trip_headsign", IsRequired = false)]
        public string TripHeadsign { get; set; }

        /// <summary>
        /// Public facing text used to identify the trip to riders, for instance, to identify train numbers for commuter rail
        /// trips. If riders do not commonly rely on trip names, leave this field empty. A trip_short_name value, if provided,
        /// should uniquely identify a trip within a service day; it should not be used for destination names or limited/express
        /// designations.
        /// </summary>
        [DataMember(Name = "trip_short_name", IsRequired = false)]
        public string TripShortName { get; set; }

        /// <summary>
        /// Indicates the direction of travel for a trip. This field is not used in routing; it provides a way to separate trips by
        /// direction when publishing time tables. Valid options are:
        /// </summary>
        [DataMember(Name = "direction_id", IsRequired = false)]
        public string DirectionId { get; set; }
    }
}