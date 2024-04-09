using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BloodTypeWeb.Models
{
    public class BloodType
    {
        [Key]
        public string BloodTypeID { get; set; } // Primary Key

        [Required]
        public string BloodTypeName { get; set; }

        // Navigation properties
        public ICollection<ParentCombinationRh> MotherCombinations { get; set; }
        public ICollection<ParentCombinationRh> FatherCombinations { get; set; }
        public ICollection<ChildOutcomeRh> ChildOutcomes { get; set; }
    }
}
