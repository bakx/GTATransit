using System.Runtime.Serialization;

namespace Models
{
    public class Translations
    {
        /// <summary>
        /// URL for contact information, a web-form, support desk, or other tools for communication regarding the GTFS dataset and
        /// data publishing practices. feed_contact_url is a technical contact for GTFS-consuming applications. Provide customer
        /// service contact information through agency.txt.
        /// </summary>
        [DataMember(Name = "feed_contact_url", IsRequired = false)]
        public string FeedContactUrl { get; set; }

        /// <summary>
        /// Defines the dataset table that contains the field to be translated. The following values are
        /// allowed:agencystopsroutestripsstop_timesfeed_infoNote: Don't include the .txt file extension after the table's name.
        /// </summary>
        [DataMember(Name = "table_name", IsRequired = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Provides the name of the field to be translated. Fields with the type "Text" can be translated, while fields with the
        /// types "URL," "Email," and "Phone number" can be included here to provide those resources in the correct language.Note:
        /// Fields with other types are ignored and will not be translated.
        /// </summary>
        [DataMember(Name = "field_name", IsRequired = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Provides the language of translation.If this language is the same as the one from feed_lang in feed_info.txt, the
        /// original value of the field is the default value used in languages without specific translations.For example, in
        /// Switzerland, a city in a bilingual canton is officially called "Biel/Bienne," but it would simply be called "Bienne" in
        /// French and "Biel" in German.
        /// </summary>
        [DataMember(Name = "language", IsRequired = true)]
        public string Language { get; set; }

        /// <summary>
        /// Provides the translated value for the specified field_name.
        /// </summary>
        [DataMember(Name = "translation", IsRequired = true)]
        public string Translation { get; set; }

        /// <summary>
        /// Defines the record that corresponds to the field to be translated. The value in record_id needs to be a main ID from a
        /// dataset table, as defined in the following table:table_nameagencystopsroutestripsstop_timespathwayslevelsThe following
        /// conditions determine how this field can be used:Forbidden if table_name equals feed_info.Forbidden if field_value is
        /// defined.Required if field_value is empty.
        /// </summary>
        [DataMember(Name = "record_id", IsRequired = false)]
        public string RecordId { get; set; }

        /// <summary>
        /// Helps to translate the record that contains the field when the table referenced in record_id doesn’t have a unique ID.
        /// The value in record_sub_id is the secondary ID of a dataset table, as defined in the following
        /// table:table_nameagencystopsroutestripsstop_timespathwayslevelsThe following conditions determine how this field can be
        /// used:Forbidden if table_name equals feed_info.Forbidden if field_value is defined.Required if table_name equals
        /// stop_times and record_id is defined.
        /// </summary>
        [DataMember(Name = "record_sub_id", IsRequired = false)]
        public string RecordSubId { get; set; }

        /// <summary>
        /// Instead of using record_id and record_sub_id to define which record needs to be translated, field_value can be used to
        /// define the value for translation. When used, the translation is applied when the field identified by table_name and
        /// field_name contains the exact same value defined in field_value.The field must exactly match the value defined in
        /// field_value. If only a subset of the value matches field_value, the translation isn't applied.If two translation rules
        /// match the same record, one with field_value and the other one with record_id, then the rule with record_id is the one
        /// that needs to be used.The following conditions determine how this field can be used:Forbidden if table_name equals
        /// feed_info.Forbidden if record_id is defined.Required if record_id is empty.
        /// </summary>
        [DataMember(Name = "field_value", IsRequired = false)]
        public string FieldValue { get; set; }
    }
}