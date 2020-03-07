using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Data
{
    public class Frequencies : Models.Frequencies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember(Name = "id")]
        public long Id { get; set; }
    }
}