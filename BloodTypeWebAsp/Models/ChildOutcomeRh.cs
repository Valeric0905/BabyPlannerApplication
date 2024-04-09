using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BloodTypeWeb.Models
{
    public class ChildOutcomeRh
    {
        [Key]
        public int OutcomeID { get; set; } // Primary Key

        [Required]
        public int CombinationID { get; set; } // Foreign Key

        [Required]
        public string? ChildBloodTypeID { get; set; }

        [Required]
        public int ChildRhFactorID { get; set; }

        [Required]
        public string? Probability { get; set; } // Example: "50%"

        // Navigation properties
        [ForeignKey("CombinationID")]
        public ParentCombinationRh? ParentCombination { get; set; }

        [ForeignKey("ChildBloodTypeID")]
        public BloodType? ChildBloodType { get; set; }

        [ForeignKey("ChildRhFactorID")]
        public RhFactor? ChildRhFactor { get; set; }
    }
}

