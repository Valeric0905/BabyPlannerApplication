namespace BloodTypeWeb.Interfaces
{
    public interface ICalculateRhFactor
    {
        Dictionary<string, int> CalculateChildRhFactor(string motherRhFactor, string fatherRhFactor);
    }
}
