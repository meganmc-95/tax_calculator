using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class DefaultTaxCalculator: TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var actualEmissions = vehicle.Co2Emissions;
            var emissionCosts = new Emissions().emissonCostMap;
            var cost = 0;

            foreach (KeyValuePair<EmissionProperties, int> condition in emissionCosts)
            {
                var lowerLimit = condition.Key.lowerLimit;
                var upperLimit = condition.Key.upperLimit;

                if (actualEmissions >= lowerLimit && actualEmissions <= upperLimit)
                {
                    cost = condition.Value;
                }
            }

            return cost;
            
            /*
            if(emissions == 0) {
                return cost;
            } 
            else if (emissions <= 50)
            {
                cost = 10;
            }
            else if (emissions <= 75)
            {
                cost = 25;
            }
            else if (emissions <= 90)
            {
                cost = 105;
            }
            else if (emissions <= 100)
            {
                cost = 125;
            }
            else if (emissions <= 110)
            {
                cost = 145;
            }
            else if (emissions <= 130)
            {
                cost = 165;
            }
            else if (emissions <= 150)
            {
                cost = 205;
            }
            else if (emissions <= 170)
            {
                cost = 515;
            }
            else if (emissions <= 190)
            {
                cost = 830;
            }
            else if (emissions <= 225)
            {
                cost = 1240;
            }
            else if (emissions <= 255)
            {
                cost = 1760;
            } 
            else
            {
                cost = 2070;
            }

            return cost;
            */
        }
    }
}
