using System.ComponentModel.DataAnnotations;

namespace BloodTypeWeb.Models
{
    public class RhFactor
    {
        [Key]
        public int RhFactorID { get; set; } // Primary Key

        [Required]
        public string RhFactorType { get; set; } // "+" or "-"

        // Navigation properties
        public ICollection<ParentCombinationRh> MotherCombinations { get; set; }
        public ICollection<ParentCombinationRh> FatherCombinations { get; set; }
        public ICollection<ChildOutcomeRh> ChildOutcomes { get; set; }
    }
}
