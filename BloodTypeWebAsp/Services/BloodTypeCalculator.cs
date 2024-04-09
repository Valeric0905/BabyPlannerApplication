using BloodTypeWeb.Interfaces;

namespace BloodTypeWeb.Services
{
    public class BloodTypeCalculator: IBloodTypeCalculator
    {
        static Dictionary<string, Dictionary<string, Dictionary<string, int>>> bloodTypeMapping = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>
        {
            {
                "O",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "O",
                        new Dictionary<string, int>
                        {
                            { "O", 100 }
                        }
                    },
                    {
                        "A",
                        new Dictionary<string, int>
                        {
                            { "O", 50 },
                            { "A", 50 }
                        }
                    },
                    {
                        "B",
                        new Dictionary<string, int>
                        {
                            { "O", 50 },
                            { "B", 50 }
                        }
                    },
                    {
                        "AB",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "B", 50 }
                        }
                    }
                }
            },
            {
                "A",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "O",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "O", 50 }
                        }
                    },
                    {
                        "A",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "O", 50 }
                        }
                    },
                    {
                        "B",
                        new Dictionary<string, int>
                        {
                            { "O", 25 },
                            { "A", 25 },
                            { "B", 25 },
                            { "AB", 25 }
                        }
                    },
                    {
                        "AB",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "B", 25 },
                            { "AB", 25 }
                        }
                    }
                }
            },
            {
                "B",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "O",
                        new Dictionary<string, int>
                        {
                            { "B", 50 },
                            { "O", 50 }
                        }
                    },
                    {
                        "A",
                        new Dictionary<string, int>
                        {
                            { "O", 25 },
                            { "A", 25 },
                            { "B", 25 },
                            { "AB", 25 }
                        }
                    },
                    {
                        "B",
                        new Dictionary<string, int>
                        {
                            { "B", 50 },
                            { "O", 50 }
                        }
                    },
                    {
                        "AB",
                        new Dictionary<string, int>
                        {
                            { "A", 25 },
                            { "B", 50 },
                            { "AB", 25 }
                        }
                    }
                }
            },
            {
                "AB",
                new Dictionary<string, Dictionary<string, int>>
                {
                    {
                        "O",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "B", 50 },
                            { "AB", 50 }
                        }
                    },
                    {
                        "A",
                        new Dictionary<string, int>
                        {
                            { "A", 50 },
                            { "B", 25 },
                            { "AB", 25 }
                        }
                    },
                    {
                        "B",
                        new Dictionary<string, int>
                        {
                            { "A", 25 },
                            { "B", 50 },
                            { "AB", 25 }
                        }
                    },
                    {
                        "AB",
                        new Dictionary<string, int>
                        {
                            { "A", 25 },
                            { "B", 25 },
                            { "AB", 50 }
                        }
                    }
                }
            }
        };
        public Dictionary<string, int> CalculateChildBloodType(string motherBloodType, string fatherBloodType)
        {
            if (!bloodTypeMapping.ContainsKey(motherBloodType) || !bloodTypeMapping.ContainsKey(fatherBloodType))
            {
                Console.WriteLine("Invalid blood types entered.");
                return null;
            }

            return bloodTypeMapping[motherBloodType][fatherBloodType];
        }
    }
}

