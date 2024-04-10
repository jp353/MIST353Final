using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIST353FinalAPI.Entities
{
    public class User
    {
        [Key]
        public int UID { get; set; }

        [Required]
        public string UFName { get; set; }

        public string? ULName { get; set; }

        public string? UPassword { get; set; }

        public string? UEmail { get; set; }

        [ForeignKey("RID")]
        public int RID { get; set; }
    }
}
