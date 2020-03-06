using System.Runtime.Serialization;

namespace Models
{
    public class Transfers
    {
        /// <summary>
        /// Identifies a stop or station where a connection between routes begins. If this field refers to a station, the transfer
        /// rule applies to all its child stops.
        /// </summary>
        [DataMember(Name = "from_stop_id", IsRequired = true)]
        public string FromStopId { get; set; }

        /// <summary>
        /// Identifies a stop or station where a connection between routes ends. If this field refers to a station, the transfer
        /// rule applies to all child stops.
        /// </summary>
        [DataMember(Name = "to_stop_id", IsRequired = true)]
        public string ToStopId { get; set; }

        /// <summary>
        /// Indicates the type of connection for the specified (from_stop_id, to_stop_id) pair. Valid options are:
        /// </summary>
        [DataMember(Name = "transfer_type", IsRequired = true)]
        public string TransferType { get; set; }
    }
}