using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace MIST353FinalAPI.Entities
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [Required]
        public DateTime CDate { get; set; }

        public decimal? Price { get; set; }

        public int? SubID { get; set; }
    }
}