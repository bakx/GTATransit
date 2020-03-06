using System.Runtime.Serialization;

namespace Models
{
    public class Levels
    {
        /// <summary>
        /// Same than the signposted_as field, but when the pathways is used backward, i.e. from the to_stop_id to the
        /// from_stop_id.
        /// </summary>
        [DataMember(Name = "reversed_signposted_as", IsRequired = false)]
        public string ReversedSignpostedAs { get; set; }

        /// <summary>
        /// Id of the level that can be referenced from stops.txt.
        /// </summary>
        [DataMember(Name = "level_id", IsRequired = true)]
        public string LevelId { get; set; }

        /// <summary>
        /// Numeric index of the level that indicates relative position of this level in relation to other levels (levels with
        /// higher indices are assumed to be located above levels with lower indices).Ground level should have index 0, with levels
        /// above ground indicated by positive indices and levels below ground by negative indices.
        /// </summary>
        [DataMember(Name = "level_index", IsRequired = true)]
        public string LevelIndex { get; set; }

        /// <summary>
        /// Optional name of the level (that matches level lettering/numbering used inside the building or the station). Is useful
        /// for elevator routing (e.g. “take the elevator to level “Mezzanine” or “Platforms” or “-1”).
        /// </summary>
        [DataMember(Name = "level_name", IsRequired = false)]
        public string LevelName { get; set; }
    }
}