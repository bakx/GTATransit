using System.Runtime.Serialization;

namespace Models
{
 public abstract class FeedInfo
 {
            /// <summary>
        /// Optional name of the level (that matches level lettering/numbering used inside the building or the station). Is useful for elevator routing (e.g. “take the elevator to level “Mezzanine” or “Platforms” or “-1”).
        /// </summary>
        [DataMember(Name = "level_name", IsRequired = false)]
        public string LevelName { get; set; }
        /// <summary>
        /// Full name of the organization that publishes the dataset. This may be the same as one of the agency.agency_name values.
        /// </summary>
        [DataMember(Name = "feed_publisher_name", IsRequired = true)]
        public string FeedPublisherName { get; set; }
        /// <summary>
        /// URL of the dataset publishing organization's website. This may be the same as one of the agency.agency_url values.
        /// </summary>
        [DataMember(Name = "feed_publisher_url", IsRequired = true)]
        public string FeedPublisherUrl { get; set; }
        /// <summary>
        /// Default language used for the text in this dataset. This setting helps GTFS consumers choose capitalization rules and other language-specific settings for the dataset.
        /// </summary>
        [DataMember(Name = "feed_lang", IsRequired = true)]
        public string FeedLang { get; set; }
        /// <summary>
        /// The dataset provides complete and reliable schedule information for service in the period from the beginning of the feed_start_date day to the end of the feed_end_date day. Both days can be left empty if unavailable. The feed_end_date date must not precede the feed_start_date date if both are given. Dataset providers are encouraged to give schedule data outside this period to advise of likely future service, but dataset consumers should treat it mindful of its non-authoritative status. If feed_start_date or feed_end_date extend beyond the active calendar dates defined in calendar.txt and calendar_dates.txt, the dataset is making an explicit assertion that there is no service for dates within the feed_start_date to feed_end_date range but not included in the active calendar dates.
        /// </summary>
        [DataMember(Name = "feed_start_date", IsRequired = false)]
        public string FeedStartDate { get; set; }
        /// <summary>
        /// (see above)
        /// </summary>
        [DataMember(Name = "feed_end_date", IsRequired = false)]
        public string FeedEndDate { get; set; }
        /// <summary>
        /// String that indicates the current version of their GTFS dataset. GTFS-consuming applications can display this value to help dataset publishers determine whether the latest dataset has been incorporated.
        /// </summary>
        [DataMember(Name = "feed_version", IsRequired = false)]
        public string FeedVersion { get; set; }
        /// <summary>
        /// Email address for communication regarding the GTFS dataset and data publishing practices. feed_contact_email is a technical contact for GTFS-consuming applications. Provide customer service contact information through agency.txt.
        /// </summary>
        [DataMember(Name = "feed_contact_email", IsRequired = false)]
        public string FeedContactEmail { get; set; }
        /// <summary>
        /// URL for contact information, a web-form, support desk, or other tools for communication regarding the GTFS dataset and data publishing practices. feed_contact_url is a technical contact for GTFS-consuming applications. Provide customer service contact information through agency.txt.
        /// </summary>
        [DataMember(Name = "feed_contact_url", IsRequired = false)]
        public string FeedContactUrl { get; set; }

 }
}