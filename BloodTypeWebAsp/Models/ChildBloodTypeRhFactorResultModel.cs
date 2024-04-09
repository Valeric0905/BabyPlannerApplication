namespace BloodTypeWeb.Models
{
    public class ChildBloodTypeRhFactorResultModel
    {
        public Dictionary<string, int> ChildBloodTypePercentages { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> ChildRhFactorPercentages { get; set; } = new Dictionary<string, int>();
    }
}
