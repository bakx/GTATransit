using System.Runtime.Serialization;

namespace Models
{
 public abstract class Pathways
 {
            /// <summary>
        /// Amount of time, in seconds, that must be available to permit a transfer between routes at the specified stops. The min_transfer_time should be sufficient to permit a typical rider to move between the two stops, including buffer time to allow for schedule variance on each route.
        /// </summary>
        [DataMember(Name = "min_transfer_time", IsRequired = false)]
        public string MinTransferTime { get; set; }
        /// <summary>
        /// The pathway_id field contains an ID that uniquely identifies the pathway. The pathway_id is used by systems as an internal identifier of this record (e.g., primary key in database), and therefore the pathway_id must be dataset unique.Different pathways can go from the same from_stop_id to the same to_stop_id. For example, this happens when two escalators are side by side in opposite direction, or when a stair is nearby and elevator and both go from the same place to the same place.
        /// </summary>
        [DataMember(Name = "pathway_id", IsRequired = true)]
        public string PathwayId { get; set; }
        /// <summary>
        /// Location at which the pathway begins. It contains a stop_id that identifies a platform, entrance/exit, generic node or boarding area from the stops.txt file.
        /// </summary>
        [DataMember(Name = "from_stop_id", IsRequired = true)]
        public string FromStopId { get; set; }
        /// <summary>
        /// Location at which the pathway ends. It contains a stop_id that identifies a platform, entrance/exit, generic node or boarding area from the stops.txt file.
        /// </summary>
        [DataMember(Name = "to_stop_id", IsRequired = true)]
        public string ToStopId { get; set; }
        /// <summary>
        /// Type of pathway between the specified (from_stop_id, to_stop_id) pair. Valid values for this field are:• 1: walkway• 2: stairs• 3: moving sidewalk/travelator• 4: escalator• 5: elevator• 6: fare gate (or payment gate): A pathway that crosses into an area of the station where a proof of payment is required (usually via a physical payment gate).Fare gates may either separate paid areas of the station from unpaid ones, or separate different payment areas within the same station from each other. This information can be used to avoid routing passengers through stations using shortcuts that would require passengers to make unnecessary payments, like directing a passenger to walk through a subway platform to reach a busway.• 7: exit gate: Indicates a pathway exiting an area where proof-of-payment is required into an area where proof-of-payment is no longer required.
        /// </summary>
        [DataMember(Name = "pathway_mode", IsRequired = true)]
        public string PathwayMode { get; set; }
        /// <summary>
        /// Indicates in which direction the pathway can be used:• 0: Unidirectional pathway, it can only be used from from_stop_id to to_stop_id.• 1: Bidirectional pathway, it can be used in the two directions.Fare gates (pathway_mode=6) and exit gates (pathway_mode=7) cannot be bidirectional.
        /// </summary>
        [DataMember(Name = "is_bidirectional", IsRequired = true)]
        public string IsBidirectional { get; set; }
        /// <summary>
        /// Horizontal length in meters of the pathway from the origin location (defined in from_stop_id) to the destination location (defined in to_stop_id).This field is recommended for walkways (pathway_mode=1), fare gates (pathway_mode=6) and exit gates (pathway_mode=7).
        /// </summary>
        [DataMember(Name = "length", IsRequired = false)]
        public string Length { get; set; }
        /// <summary>
        /// Average time in seconds needed to walk through the pathway from the origin location (defined in from_stop_id) to the destination location (defined in to_stop_id).This field is recommended for moving sidewalks (pathway_mode=3), escalators (pathway_mode=4) and elevator (pathway_mode=5).
        /// </summary>
        [DataMember(Name = "traversal_time", IsRequired = false)]
        public string TraversalTime { get; set; }
        /// <summary>
        /// Number of stairs of the pathway.Best Practices: one could use the approximation of 1 floor = 15 stairs to generate approximative values.A positive stair_count implies that the rider walk up from from_stop_id to to_stop_id. And a negative stair_count implies that the rider walk down from from_stop_id to to_stop_id.This field is recommended for stairs (pathway_mode=2).
        /// </summary>
        [DataMember(Name = "stair_count", IsRequired = false)]
        public string StairCount { get; set; }
        /// <summary>
        /// Maximum slope ratio of the pathway. Valid values for this field are:• 0 or (empty): no slope.• A float: slope ratio of the pathway, positive for upwards, negative for downwards.This field should be used only with walkways (pathway_type=1) and moving sidewalks (pathway_type=3).Example: In the US, 0.083 (also written 8.3%) is the maximum slope ratio for hand-propelled wheelchair, which mean an increase of 0.083m (so 8.3cm) for each 1m.
        /// </summary>
        [DataMember(Name = "max_slope", IsRequired = false)]
        public string MaxSlope { get; set; }
        /// <summary>
        /// Minimum width of the pathway in meters.This field is highly recommended if the minimum width is less than 1 meter.
        /// </summary>
        [DataMember(Name = "min_width", IsRequired = false)]
        public string MinWidth { get; set; }
        /// <summary>
        /// String of text from physical signage visible to transit riders. The string can be used to provide text directions to users, such as 'follow signs to '. The language text should appear in this field exactly how it is printed on the signs - it should not be translated.
        /// </summary>
        [DataMember(Name = "signposted_as", IsRequired = false)]
        public string SignpostedAs { get; set; }
        /// <summary>
        /// Same than the signposted_as field, but when the pathways is used backward, i.e. from the to_stop_id to the from_stop_id.
        /// </summary>
        [DataMember(Name = "reversed_signposted_as", IsRequired = false)]
        public string ReversedSignpostedAs { get; set; }

 }
}