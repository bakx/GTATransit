using System.Runtime.Serialization;

//
// This class does not exists in the documentation. It was present in the files supplied by Metrolinx.
// Amentities is misspelled by the source.

namespace Models
{
    public class StopAmentities
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "stop_id", IsRequired = false)]
        public string StopId { get; set; }

        /// <summary>
        /// Does this stop have a shelter?
        /// </summary>
        [DataMember(Name = "shelter", IsRequired = false)]
        public string Shelter { get; set; }

        /// <summary>
        /// Does this stop have a washroom?
        /// </summary>
        [DataMember(Name = "washroom", IsRequired = false)]
        public string Washroom { get; set; }

        /// <summary>
        /// Does this stop have a bike rack?
        /// </summary>
        [DataMember(Name = "bike_rack", IsRequired = false)]
        public string BikeRack { get; set; }

        /// <summary>
        /// Does this stop have a bench?
        /// </summary>
        [DataMember(Name = "bench", IsRequired = false)]
        public string Bench { get; set; }
    }
}