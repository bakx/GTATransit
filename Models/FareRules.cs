using System.Runtime.Serialization;

namespace Models
{
    public class FareRules
    {
        /// <summary>
        /// Length of time in seconds before a transfer expires. When transfers=0 this field can be used to indicate how long a
        /// ticket is valid for or it can can be left empty.
        /// </summary>
        [DataMember(Name = "transfer_duration", IsRequired = false)]
        public string TransferDuration { get; set; }

        /// <summary>
        /// Identifies a fare class.
        /// </summary>
        [DataMember(Name = "fare_id", IsRequired = true)]
        public string FareId { get; set; }

        /// <summary>
        /// Identifies a route associated with the fare class. If several routes with the same fare attributes exist, create a
        /// record in fare_rules.txt for each route.Example: If fare class "b" is valid on route "TSW" and "TSE", the
        /// fare_rules.txt file would contain these records for the fare class:fare_id,route_idb,TSWb,TSE
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = false)]
        public string RouteId { get; set; }

        /// <summary>
        /// Identifies an origin zone. If a fare class has multiple origin zones, create a record in fare_rules.txt for each
        /// origin_id.Example: If fare class "b" is valid for all travel originating from either zone "2" or zone "8", the
        /// fare_rules.txt file would contain these records for the fare class:fare_id,...,origin_idb,...,2b,...,8
        /// </summary>
        [DataMember(Name = "origin_id", IsRequired = false)]
        public string OriginId { get; set; }

        /// <summary>
        /// Identifies a destination zone. If a fare class has multiple destination zones, create a record in fare_rules.txt for
        /// each destination_id.Example: The origin_id and destination_id fields could be used together to specify that fare class
        /// "b" is valid for travel between zones 3 and 4, and for travel between zones 3 and 5, the fare_rules.txt file would
        /// contain these records for the fare class:fare_id,...,origin_id,destination_idb,...,3,4b,...,3,5
        /// </summary>
        [DataMember(Name = "destination_id", IsRequired = false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Identifies the zones that a rider will enter while using a given fare class. Used in some systems to calculate correct
        /// fare class.Example: If fare class "c" is associated with all travel on the GRT route that passes through zones 5, 6,
        /// and 7 the fare_rules.txt would contain these
        /// records:fare_id,route_id,...,contains_idc,GRT,...,5c,GRT,...,6c,GRT,...,7Because all contains_id zones must be matched
        /// for the fare to apply, an itinerary that passes through zones 5 and 6 but not zone 7 would not have fare class "c". For
        /// more detail, see https://code.google.com/p/googletransitdatafeed/wiki/FareExamples in the GoogleTransitDataFeed project
        /// wiki.
        /// </summary>
        [DataMember(Name = "contains_id", IsRequired = false)]
        public string ContainsId { get; set; }
    }
}