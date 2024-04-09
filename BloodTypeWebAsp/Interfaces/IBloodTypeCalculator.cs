namespace BloodTypeWeb.Interfaces
{
    public interface IBloodTypeCalculator
    {
        Dictionary<string, int> CalculateChildBloodType(string motherBloodType, string fatherBloodType);
    }

}
