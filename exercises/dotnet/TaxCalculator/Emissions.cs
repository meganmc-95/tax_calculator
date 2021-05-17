using System.Collections.Generic;

namespace TaxCalculator
{
    class Emissions
    {
        public Dictionary<EmissionProperties, int> emissonCostMap = new Dictionary<EmissionProperties, int>()
        {
            { new EmissionProperties { lowerLimit = 0, upperLimit = 0 }, 0 },
            { new EmissionProperties { lowerLimit = 1, upperLimit = 50 }, 10 },
            { new EmissionProperties { lowerLimit = 51, upperLimit = 75 }, 25 },
            { new EmissionProperties { lowerLimit = 76, upperLimit = 90 }, 105 },
            { new EmissionProperties { lowerLimit = 91, upperLimit = 100 }, 125 },
            { new EmissionProperties { lowerLimit = 101, upperLimit = 110 }, 145 },
            { new EmissionProperties { lowerLimit = 111, upperLimit = 130 }, 165 },
            { new EmissionProperties { lowerLimit = 131, upperLimit = 150 }, 205 },
            { new EmissionProperties { lowerLimit = 151, upperLimit = 170 }, 515 },
            { new EmissionProperties { lowerLimit = 171, upperLimit = 190 }, 830 },
            { new EmissionProperties { lowerLimit = 191, upperLimit = 225 }, 1240 },
            { new EmissionProperties { lowerLimit = 226, upperLimit = 255 }, 1760 },
            { new EmissionProperties { lowerLimit = 256, upperLimit = 1000 }, 2070 }
        };
    }

    internal class EmissionProperties
    {
        public int lowerLimit;
        public int upperLimit;
    }
}