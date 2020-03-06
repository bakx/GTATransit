using System.Runtime.Serialization;

namespace Models
{
    public class Attributions
    {
        /// <summary>
        /// Identifies an attribution for the dataset, or a subset of it. This field is useful for translations.
        /// </summary>
        [DataMember(Name = "attribution_id", IsRequired = false)]
        public string AttributionId { get; set; }

        /// <summary>
        /// The agency to which the attribution applies. If one agency_id, route_id, or trip_id attribution is defined, the other
        /// fields must be empty. If none are specified, the attribution applies to the whole dataset.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }

        /// <summary>
        /// This field functions in the same way as agency_id, except the attribution applies to a route. Multiple attributions can
        /// apply to the same route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = false)]
        public string RouteId { get; set; }

        /// <summary>
        /// This field functions in the same way as agency_id, except the attribution applies to a trip. Multiple attributions can
        /// apply to the same trip.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = false)]
        public string TripId { get; set; }

        /// <summary>
        /// The name of the organization that the dataset is attributed to.
        /// </summary>
        [DataMember(Name = "organization_name", IsRequired = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// The role of the organization is producer. Allowed values include the following:
        /// </summary>
        [DataMember(Name = "is_producer", IsRequired = false)]
        public string IsProducer { get; set; }
    }
}