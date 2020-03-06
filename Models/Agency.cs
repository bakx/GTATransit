using System.Runtime.Serialization;

namespace Models
{
    public class Agency
    {
        /// <summary>
        /// Identifies a transit brandwhich is often synonymous with a transit agency. Note that in some cases, such as when a
        /// single agency operates multiple separate services, agencies and brands are distinct. This document uses the term
        /// "agency" in place of "brand". A dataset may contain data from multiple agencies. This field is required when the
        /// dataset contains data for multiple transit agencies, otherwise it is optional.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }

        /// <summary>
        /// Full name of the transit agency.
        /// </summary>
        [DataMember(Name = "agency_name", IsRequired = true)]
        public string AgencyName { get; set; }

        /// <summary>
        /// URL of the transit agency.
        /// </summary>
        [DataMember(Name = "agency_url", IsRequired = true)]
        public string AgencyUrl { get; set; }

        /// <summary>
        /// Timezone where the transit agency is located. If multiple agencies are specified in the dataset, each must have the
        /// same agency_timezone.
        /// </summary>
        [DataMember(Name = "agency_timezone", IsRequired = true)]
        public string AgencyTimezone { get; set; }

        /// <summary>
        /// Primary language used by this transit agency. This field helps GTFS consumers choose capitalization rules and other
        /// language-specific settings for the dataset.
        /// </summary>
        [DataMember(Name = "agency_lang", IsRequired = false)]
        public string AgencyLang { get; set; }

        /// <summary>
        /// A voice telephone number for the specified agency. This field is a string value that presents the telephone number as
        /// typical for the agency's service area. It can and should contain punctuation marks to group the digits of the number.
        /// Dialable text (for example, TriMet's "503-238-RIDE") is permitted, but the field must not contain any other descriptive
        /// text.
        /// </summary>
        [DataMember(Name = "agency_phone", IsRequired = false)]
        public string AgencyPhone { get; set; }

        /// <summary>
        /// URL of a web page that allows a rider to purchase tickets or other fare instruments for that agency online.
        /// </summary>
        [DataMember(Name = "agency_fare_url", IsRequired = false)]
        public string AgencyFareUrl { get; set; }

        /// <summary>
        /// Email address actively monitored by the agency’s customer service department. This email address should be a direct
        /// contact point where transit riders can reach a customer service representative at the agency.
        /// </summary>
        [DataMember(Name = "agency_email", IsRequired = false)]
        public string AgencyEmail { get; set; }
    }
}