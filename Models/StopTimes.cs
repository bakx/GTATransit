using System.Runtime.Serialization;

namespace Models
{
 public abstract class StopTimes
 {
            /// <summary>
        /// Indicates whether bikes are allowed. Valid options are:0 or empty - No bike information for the trip.1 - Vehicle being used on this particular trip can accommodate at least one bicycle.2 - No bicycles are allowed on this trip.
        /// </summary>
        [DataMember(Name = "bikes_allowed", IsRequired = false)]
        public string BikesAllowed { get; set; }
        /// <summary>
        /// Identifies a trip.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = true)]
        public string TripId { get; set; }
        /// <summary>
        /// Arrival time at a specific stop for a specific trip on a route. If there are not separate times for arrival and departure at a stop, enter the same value for arrival_time and departure_time. For times occurring after midnight on the service day, enter the time as a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins.Scheduled stops where the vehicle strictly adheres to the specified arrival and departure times are timepoints. If this stop is not a timepoint, it is recommended to provide an estimated or interpolated time. If this is not available, arrival_time can be left empty. Further, indicate that interpolated times are provided with timepoint=0. If interpolated times are indicated with timepoint=0, then time points must be indicated with timepoint=1. Provide arrival times for all stops that are time points. An arrival time must be specified for the first and the last stop in a trip.
        /// </summary>
        [DataMember(Name = "arrival_time", IsRequired = false)]
        public string ArrivalTime { get; set; }
        /// <summary>
        /// Departure time from a specific stop for a specific trip on a route. For times occurring after midnight on the service day, enter the time as a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. If there are not separate times for arrival and departure at a stop, enter the same value for arrival_time and departure_time. See the arrival_time description for more details about using timepoints correctly.The departure_time field should specify time values whenever possible, including non-binding estimated or interpolated times between timepoints.
        /// </summary>
        [DataMember(Name = "departure_time", IsRequired = false)]
        public string DepartureTime { get; set; }
        /// <summary>
        /// Identifies the serviced stop. All stops serviced during a trip must have a record in stop_times.txt. Referenced locations must be stops, not stations or station entrances. A stop may be serviced multiple times in the same trip, and multiple trips and routes may service the same stop.
        /// </summary>
        [DataMember(Name = "stop_id", IsRequired = true)]
        public string StopId { get; set; }
        /// <summary>
        /// Order of stops for a particular trip. The values must increase along the trip but do not need to be consecutive.Example: The first location on the trip could have a stop_sequence=1, the second location on the trip could have a stop_sequence=23, the third location could have a stop_sequence=40, and so on.
        /// </summary>
        [DataMember(Name = "stop_sequence", IsRequired = true)]
        public string StopSequence { get; set; }
        /// <summary>
        /// Text that appears on signage identifying the trip's destination to riders. This field overrides the default trips.trip_headsign when the headsign changes between stops. If the headsign is displayed for an entire trip, use trips.trip_headsign instead.A stop_headsign value specified for one stop_time does not apply to subsequent stop_times in the same trip. If you want to override the trip_headsign for multiple stop_times in the same trip, the stop_headsign value must be repeated in each stop_time row.
        /// </summary>
        [DataMember(Name = "stop_headsign", IsRequired = false)]
        public string StopHeadsign { get; set; }
        /// <summary>
        /// Indicates pickup method. Valid options are:0 or empty - Regularly scheduled pickup.1 - No pickup available.2 - Must phone agency to arrange pickup.3 - Must coordinate with driver to arrange pickup.
        /// </summary>
        [DataMember(Name = "pickup_type", IsRequired = false)]
        public string PickupType { get; set; }
        /// <summary>
        /// Indicates drop off method. Valid options are:0 or empty - Regularly scheduled drop off.1 - No drop off available.2 - Must phone agency to arrange drop off.3 - Must coordinate with driver to arrange drop off.
        /// </summary>
        [DataMember(Name = "drop_off_type", IsRequired = false)]
        public string DropOffType { get; set; }
        /// <summary>
        /// Actual distance traveled along the associated shape, from the first stop to the stop specified in this record. This field specifies how much of the shape to draw between any two stops during a trip. Must be in the same units used in shapes.txt. Values used for shape_dist_traveled must increase along with stop_sequence; they cannot be used to show reverse travel along a route.Example: If a bus travels a distance of 5.25 kilometers from the start of the shape to the stop,shape_dist_traveled=5.25.
        /// </summary>
        [DataMember(Name = "shape_dist_traveled", IsRequired = false)]
        public string ShapeDistTraveled { get; set; }
        /// <summary>
        /// Indicates if arrival and departure times for a stop are strictly adhered to by the vehicle or if they are instead approximate and/or interpolated times. This field allows a GTFS producer to provide interpolated stop-times, while indicating that the times are approximate. Valid options are:0 - Times are considered approximate.1 or empty - Times are considered exact.
        /// </summary>
        [DataMember(Name = "timepoint", IsRequired = false)]
        public string Timepoint { get; set; }

 }
}