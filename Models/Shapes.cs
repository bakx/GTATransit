using System.Runtime.Serialization;

namespace Models
{
 public abstract class Shapes
 {
            /// <summary>
        /// Identifies the zones that a rider will enter while using a given fare class. Used in some systems to calculate correct fare class.Example: If fare class "c" is associated with all travel on the GRT route that passes through zones 5, 6, and 7 the fare_rules.txt would contain these records:fare_id,route_id,...,contains_idc,GRT,...,5c,GRT,...,6c,GRT,...,7Because all contains_id zones must be matched for the fare to apply, an itinerary that passes through zones 5 and 6 but not zone 7 would not have fare class "c". For more detail, see https://code.google.com/p/googletransitdatafeed/wiki/FareExamples in the GoogleTransitDataFeed project wiki.
        /// </summary>
        [DataMember(Name = "contains_id", IsRequired = false)]
        public string ContainsId { get; set; }
        /// <summary>
        /// Identifies a shape.
        /// </summary>
        [DataMember(Name = "shape_id", IsRequired = true)]
        public string ShapeId { get; set; }
        /// <summary>
        /// Latitude of a shape point. Each record in shapes.txt represents a shape point used to define the shape.
        /// </summary>
        [DataMember(Name = "shape_pt_lat", IsRequired = true)]
        public string ShapePtLat { get; set; }
        /// <summary>
        /// Longitude of a shape point.
        /// </summary>
        [DataMember(Name = "shape_pt_lon", IsRequired = true)]
        public string ShapePtLon { get; set; }
        /// <summary>
        /// Sequence in which the shape points connect to form the shape. Values must increase along the trip but do not need to be consecutive.Example: If the shape "A_shp" has three points in its definition, the shapes.txt file might contain these records to define the shape:shape_id,shape_pt_lat,shape_pt_lon,shape_pt_sequenceA_shp,37.61956,-122.48161,0A_shp,37.64430,-122.41070,6A_shp,37.65863,-122.30839,11
        /// </summary>
        [DataMember(Name = "shape_pt_sequence", IsRequired = true)]
        public string ShapePtSequence { get; set; }
        /// <summary>
        /// Actual distance traveled along the shape from the first shape point to the point specified in this record. Used by trip planners to show the correct portion of the shape on a map. Values must increase along with shape_pt_sequence; they cannot be used to show reverse travel along a route. Distance units must be consistent with those used in stop_times.txt.Example: If a bus travels along the three points defined above for A_shp, the additional shape_dist_traveled values (shown here in kilometers) would look like this:shape_id,shape_pt_lat,shape_pt_lon,shape_pt_sequence,shape_dist_traveledA_shp,37.61956,-122.48161,0,0A_shp,37.64430,-122.41070,6,6.8310A_shp,37.65863,-122.30839,11,15.8765
        /// </summary>
        [DataMember(Name = "shape_dist_traveled", IsRequired = false)]
        public string ShapeDistTraveled { get; set; }

 }
}