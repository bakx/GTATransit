using System.Runtime.Serialization;

namespace Models
{
 public abstract class Frequencies
 {
            /// <summary>
        /// Actual distance traveled along the shape from the first shape point to the point specified in this record. Used by trip planners to show the correct portion of the shape on a map. Values must increase along with shape_pt_sequence; they cannot be used to show reverse travel along a route. Distance units must be consistent with those used in stop_times.txt.Example: If a bus travels along the three points defined above for A_shp, the additional shape_dist_traveled values (shown here in kilometers) would look like this:shape_id,shape_pt_lat,shape_pt_lon,shape_pt_sequence,shape_dist_traveledA_shp,37.61956,-122.48161,0,0A_shp,37.64430,-122.41070,6,6.8310A_shp,37.65863,-122.30839,11,15.8765
        /// </summary>
        [DataMember(Name = "shape_dist_traveled", IsRequired = false)]
        public string ShapeDistTraveled { get; set; }
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
        /// Time, in seconds, between departures from the same stop (headway) for the trip, during the time interval specified by start_time and end_time. Multiple headways for the same trip are allowed, but may not overlap. New headways may start at the exact time the previous headway ends.
        /// </summary>
        [DataMember(Name = "headway_secs", IsRequired = true)]
        public string HeadwaySecs { get; set; }
        /// <summary>
        /// Indicates the type of service for a trip. See the file description for more information. Valid options are:0 or empty - Frequency-based trips.1 - Schedule-based trips with the exact same headway throughout the day. In this case the end_time value must be greater than the last desired trip start_time but less than the last desired trip start_time + headway_secs.
        /// </summary>
        [DataMember(Name = "exact_times", IsRequired = false)]
        public string ExactTimes { get; set; }

 }
}