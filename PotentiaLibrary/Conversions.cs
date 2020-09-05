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

    }
}
