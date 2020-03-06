using System.Runtime.Serialization;

namespace Models
{
    public class FareRules
    {
        /// <summary>
        /// Identifies a fare class.
        /// </summary>
        [DataMember(Name = "fare_id", IsRequired = true)]
        public string FareId { get; set; }

        /// <summary>
        /// Identifies a route associated with the fare class. If several routes with the same fare attributes exist, create a
        /// record in fare_rules.txt for each route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = false)]
        public string RouteId { get; set; }
    }
}