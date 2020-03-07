using System.Runtime.Serialization;

namespace Models
{
 public abstract class Trips
 {
            /// <summary>
        /// Orders the routes in a way which is ideal for presentation to customers. Routes with smaller route_sort_order values should be displayed first.
        /// </summary>
        [DataMember(Name = "route_sort_order", IsRequired = false)]
        public string RouteSortOrder { get; set; }
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
        /// Text that appears on signage identifying the trip's destination to riders. Use this field to distinguish between different patterns of service on the same route. If the headsign changes during a trip, trip_headsign can be overridden by specifying values for the stop_times.stop_headsign.
        /// </summary>
        [DataMember(Name = "trip_headsign", IsRequired = false)]
        public string TripHeadsign { get; set; }
        /// <summary>
        /// Public facing text used to identify the trip to riders, for instance, to identify train numbers for commuter rail trips. If riders do not commonly rely on trip names, leave this field empty. A trip_short_name value, if provided, should uniquely identify a trip within a service day; it should not be used for destination names or limited/express designations.
        /// </summary>
        [DataMember(Name = "trip_short_name", IsRequired = false)]
        public string TripShortName { get; set; }
        /// <summary>
        /// Indicates the direction of travel for a trip. This field is not used in routing; it provides a way to separate trips by direction when publishing time tables. Valid options are:0 - Travel in one direction (e.g. outbound travel).1 - Travel in the opposite direction (e.g. inbound travel).Example: The trip_headsign and direction_id fields could be used together to assign a name to travel in each direction for a set of trips. A trips.txt file could contain these records for use in time tables:trip_id,...,trip_headsign,direction_id1234,...,Airport,01505,...,Downtown,1
        /// </summary>
        [DataMember(Name = "direction_id", IsRequired = false)]
        public string DirectionId { get; set; }
        /// <summary>
        /// Identifies the block to which the trip belongs. A block consists of a single trip or many sequential trips made using the same vehicle, defined by shared service days and block_id. A block_id can have trips with different service days, making distinct blocks. See the example below
        /// </summary>
        [DataMember(Name = "block_id", IsRequired = false)]
        public string BlockId { get; set; }
        /// <summary>
        /// Identifies a geospatial shape describing the vehicle travel path for a trip.
        /// </summary>
        [DataMember(Name = "shape_id", IsRequired = false)]
        public string ShapeId { get; set; }
        /// <summary>
        /// Indicates wheelchair accessibility. Valid options are:0 or empty - No accessibility information for the trip.1 - Vehicle being used on this particular trip can accommodate at least one rider in a wheelchair.2 - No riders in wheelchairs can be accommodated on this trip.
        /// </summary>
        [DataMember(Name = "wheelchair_accessible", IsRequired = false)]
        public string WheelchairAccessible { get; set; }
        /// <summary>
        /// Indicates whether bikes are allowed. Valid options are:0 or empty - No bike information for the trip.1 - Vehicle being used on this particular trip can accommodate at least one bicycle.2 - No bicycles are allowed on this trip.
        /// </summary>
        [DataMember(Name = "bikes_allowed", IsRequired = false)]
        public string BikesAllowed { get; set; }

 }
}