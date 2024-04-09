using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BloodTypeWeb.Models
{
    public class ParentCombinationRh
    {
        [Key]
        public int CombinationID { get; set; } // Primary Key

        [Required]
        public string? MotherBloodTypeID { get; set; }

        [Required]
        public string? FatherBloodTypeID { get; set; }

        [Required]
        public int MotherRhFactorID { get; set; }

        [Required]
        public int FatherRhFactorID { get; set; }

        // Navigation properties
        [ForeignKey("MotherBloodTypeID")]
        public BloodType? MotherBloodType { get; set; }

        [ForeignKey("FatherBloodTypeID")]
        public BloodType? FatherBloodType { get; set; }

        [ForeignKey("MotherRhFactorID")]
        public RhFactor? MotherRhFactor { get; set; }

        [ForeignKey("FatherRhFactorID")]
        public RhFactor? FatherRhFactor { get; set; }

        public ICollection<ChildOutcomeRh>? ChildOutcomes { get; set; }
    }
}
