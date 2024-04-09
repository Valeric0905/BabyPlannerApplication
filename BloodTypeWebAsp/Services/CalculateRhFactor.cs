using BloodTypeWeb.Interfaces;

namespace BloodTypeWeb.Services
{
        public class CalculateRhFactor : ICalculateRhFactor
        {
            public static Dictionary<string, Dictionary<string, Dictionary<string, int>>> rhFactorCombinations =
            new Dictionary<string, Dictionary<string, Dictionary<string, int>>>
            {
            {
                "-",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "-",
                        new Dictionary<string, int>
                        {
                            { "-", 100 }
                        }
                    },
                    {
                        "+",
                        new Dictionary<string, int>
                        {
                            { "+", 50 },
                            { "-", 50 }
                        }
                    },
                }
             },
            {
                "+",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "+",
                        new Dictionary<string, int>
                        {
                            { "+", 94 },
                            { "-", 6 }
                        }
                    },
                    {
                        "-",
                        new Dictionary<string, int>
                        {
                            { "+", 50 },
                            { "-", 50 }
                        }
                    },
                }
            },
            };

            public Dictionary<string, int> CalculateChildRhFactor(string motherRhFactor, string fatherRhFactor)
            {
                if (!rhFactorCombinations.ContainsKey(motherRhFactor) || !rhFactorCombinations.ContainsKey(fatherRhFactor))
                {
                    Console.WriteLine("Invalid Rh factors entered.");
                    return null;
                }

                return rhFactorCombinations[motherRhFactor][fatherRhFactor];

            }
        }
  }

