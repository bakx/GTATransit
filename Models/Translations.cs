using System.Runtime.Serialization;

namespace Models
{
    public class Translations
    {
        /// <summary>
        /// Defines the dataset table that contains the field to be translated. The following values are allowed:
        /// </summary>
        [DataMember(Name = "table_name", IsRequired = true)]
        public string TableName { get; set; }
    }
}