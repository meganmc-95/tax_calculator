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
            var emissionCosts = new Dictionary<EmissionProperties, int>();
            var petrolCosts = new Emissions().petrolEmissions;
            var dieselCosts = new Emissions().dieselEmissions;
            var alternativeFuelCosts = new Emissions().alternativeFuelEmissions;
            var cost = 0;

            switch(vehicle.FuelType)
            {
                case FuelType.Petrol:
                    emissionCosts = petrolCosts;
                    break;
                case FuelType.Diesel:
                    emissionCosts = dieselCosts;
                    break;
                case FuelType.AlternativeFuel:
                    emissionCosts = alternativeFuelCosts;
                    break;
            }

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
        }
    }
}
