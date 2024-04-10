using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIST353FinalAPI.Entities
{
    public class Climate_Event
    {
        [Key]
        public int EventNum { get; set; }

        public string CEType { get; set; }

        [Column(TypeName = "Date")]
        public DateTime CEDate { get; set; }

        public decimal CESeverity { get; set; }

        public int RNum { get; set; }

        [ForeignKey("RNum")]
        public virtual Region Region { get; set; }
    }
}
