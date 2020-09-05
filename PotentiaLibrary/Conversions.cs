using Potentia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotentiaLibrary
{
    public class Conversions
    {
        public static decimal KilogramsToPounds(decimal measurement)
        {
            var calculatedMeasurement = Decimal.Multiply(measurement, (decimal)2.20462262185);
            return calculatedMeasurement;

        }

        public static decimal PoundsToKilograms(decimal measurement)
        {
            var calculatedMeasurement = Decimal.Divide(measurement, (decimal)2.20462262185);
            return calculatedMeasurement;
        }

        public static Lift AssignMetrics(UserInfo userInfo)
        {

            decimal weightInKilograms;
            decimal weightInPounds;

            if (userInfo.Metric == "kilograms")
            {
                weightInPounds = Conversions.KilogramsToPounds(userInfo.Weight);
                weightInKilograms = userInfo.Weight;

            }

            else if (userInfo.Metric == "pounds")
            {
                weightInPounds = userInfo.Weight;
                weightInKilograms = Conversions.PoundsToKilograms(userInfo.Weight);


            }
            else { weightInPounds = 0; weightInKilograms = 0; }

            return new Lift
            {
                Kilograms = weightInKilograms,
                Pounds = weightInPounds
            };
        }

    }
}
