using System.Runtime.Serialization;

namespace Models
{
    public class Stops
    {
        /// <summary>
        /// Identifies a stop, station, or station entrance.
        /// </summary>
        [DataMember(Name = "stop_id", IsRequired = true)]
        public string StopId { get; set; }
    }
}