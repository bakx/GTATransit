using System.Runtime.Serialization;

namespace Models
{
    public class Shapes
    {
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
        /// Sequence in which the shape points connect to form the shape. Values must increase along the trip but do not need to be
        /// consecutive.
        /// </summary>
        [DataMember(Name = "shape_pt_sequence", IsRequired = true)]
        public string ShapePtSequence { get; set; }
    }
}