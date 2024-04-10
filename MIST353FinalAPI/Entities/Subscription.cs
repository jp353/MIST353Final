using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace MIST353FinalAPI.Entities
{
    public class Subscription

    {
        [Key]
        public int SubID { get; set; }

        [Required]
        public string? SType { get; set; }

        [Required]
        public string? SCost { get; set; }

    }
}