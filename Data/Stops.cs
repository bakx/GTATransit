using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Data
{
    public class Stops : Models.Stops
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember(Name = "id")]
        public long Id { get; set; }
    }
}