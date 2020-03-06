using System.Runtime.Serialization;

namespace Models
{
    public class Levels
    {
        /// <summary>
        /// Id of the level that can be referenced from stops.txt.
        /// </summary>
        [DataMember(Name = "level_id", IsRequired = true)]
        public string LevelId { get; set; }

        /// <summary>
        /// Numeric index of the level that indicates relative position of this level in relation to other levels (levels with
        /// higher indices are assumed to be located above levels with lower indices).
        /// </summary>
        [DataMember(Name = "level_index", IsRequired = true)]
        public string LevelIndex { get; set; }
    }
}