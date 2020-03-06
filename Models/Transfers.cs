using System.Runtime.Serialization;

namespace Models
{
    public class Transfers
    {
        /// <summary>
        /// Indicates the type of service for a trip. See the file description for more information. Valid options are:0 or empty -
        /// Frequency-based trips.1 - Schedule-based trips with the exact same headway throughout the day. In this case the
        /// end_time value must be greater than the last desired trip start_time but less than the last desired trip start_time +
        /// headway_secs.
        /// </summary>
        [DataMember(Name = "exact_times", IsRequired = false)]
        public string ExactTimes { get; set; }

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
        /// Indicates the type of connection for the specified (from_stop_id, to_stop_id) pair. Valid options are:0 or empty -
        /// Recommended transfer point between routes.1 - Timed transfer point between two routes. The departing vehicle is
        /// expected to wait for the arriving one and leave sufficient time for a rider to transfer between routes.2 - Transfer
        /// requires a minimum amount of time between arrival and departure to ensure a connection. The time required to transfer
        /// is specified by min_transfer_time.3 - Transfers are not possible between routes at the location.
        /// </summary>
        [DataMember(Name = "transfer_type", IsRequired = true)]
        public string TransferType { get; set; }

        /// <summary>
        /// Amount of time, in seconds, that must be available to permit a transfer between routes at the specified stops. The
        /// min_transfer_time should be sufficient to permit a typical rider to move between the two stops, including buffer time
        /// to allow for schedule variance on each route.
        /// </summary>
        [DataMember(Name = "min_transfer_time", IsRequired = false)]
        public string MinTransferTime { get; set; }
    }
}