using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MIST353FinalAPI.Entities
{
    public class Region
    {
        [Key]
        public int RNum { get; set; }

        public string RName { get; set; }
    }
}
