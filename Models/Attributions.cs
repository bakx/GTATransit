using System.Runtime.Serialization;

namespace Models
{
 public abstract class Attributions
 {
            /// <summary>
        /// Instead of using record_id and record_sub_id to define which record needs to be translated, field_value can be used to define the value for translation. When used, the translation is applied when the field identified by table_name and field_name contains the exact same value defined in field_value.The field must exactly match the value defined in field_value. If only a subset of the value matches field_value, the translation isn't applied.If two translation rules match the same record, one with field_value and the other one with record_id, then the rule with record_id is the one that needs to be used.The following conditions determine how this field can be used:Forbidden if table_name equals feed_info.Forbidden if record_id is defined.Required if record_id is empty.
        /// </summary>
        [DataMember(Name = "field_value", IsRequired = false)]
        public string FieldValue { get; set; }
        /// <summary>
        /// Identifies an attribution for the dataset, or a subset of it. This field is useful for translations.
        /// </summary>
        [DataMember(Name = "attribution_id", IsRequired = false)]
        public string AttributionId { get; set; }
        /// <summary>
        /// The agency to which the attribution applies. If one agency_id, route_id, or trip_id attribution is defined, the other fields must be empty. If none are specified, the attribution applies to the whole dataset.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }
        /// <summary>
        /// This field functions in the same way as agency_id, except the attribution applies to a route. Multiple attributions can apply to the same route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = false)]
        public string RouteId { get; set; }
        /// <summary>
        /// This field functions in the same way as agency_id, except the attribution applies to a trip. Multiple attributions can apply to the same trip.
        /// </summary>
        [DataMember(Name = "trip_id", IsRequired = false)]
        public string TripId { get; set; }
        /// <summary>
        /// The name of the organization that the dataset is attributed to.
        /// </summary>
        [DataMember(Name = "organization_name", IsRequired = true)]
        public string OrganizationName { get; set; }
        /// <summary>
        /// The role of the organization is producer. Allowed values include the following:• 0 or empty: Organization doesn’t have this role.• 1: Organization does have this role.At least one of the fields, either is_producer, is_operator, or is_authority, must be set at 1.
        /// </summary>
        [DataMember(Name = "is_producer", IsRequired = false)]
        public string IsProducer { get; set; }
        /// <summary>
        /// Functions in the same way as is_producer, except the role of the organization is operator.
        /// </summary>
        [DataMember(Name = "is_operator", IsRequired = false)]
        public string IsOperator { get; set; }
        /// <summary>
        /// Functions in the same way as is_producer, except the role of the organization is authority.
        /// </summary>
        [DataMember(Name = "is_authority", IsRequired = false)]
        public string IsAuthority { get; set; }
        /// <summary>
        /// The URL of the organization.
        /// </summary>
        [DataMember(Name = "attribution_url", IsRequired = false)]
        public string AttributionUrl { get; set; }
        /// <summary>
        /// The email of the organization.
        /// </summary>
        [DataMember(Name = "attribution_email", IsRequired = false)]
        public string AttributionEmail { get; set; }
        /// <summary>
        /// The phone number of the organization.
        /// </summary>
        [DataMember(Name = "attribution_phone", IsRequired = false)]
        public string AttributionPhone { get; set; }

 }
}