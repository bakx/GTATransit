using System.Runtime.Serialization;

namespace Models
{
    public class Pathways
    {
        /// <summary>
        /// The pathway_id field contains an ID that uniquely identifies the pathway. The pathway_id is used by systems as an
        /// internal identifier of this record (e.g., primary key in database), and therefore the pathway_id must be dataset
        /// unique.
        /// </summary>
        [DataMember(Name = "pathway_id", IsRequired = true)]
        public string PathwayId { get; set; }
    }
}