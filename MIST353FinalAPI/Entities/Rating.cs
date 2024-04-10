using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using system;

namespace MIST353FinalAPI.Entities
{
    public class Rating
    {
        [Key]
        public int RID { get; set; }
        public int RScore { get; set; }
        public string RComment { get; set; }
    }
}
