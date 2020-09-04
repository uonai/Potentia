using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Potentia
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

        public static decimal CalculateOneRepMax(int reps, decimal weight)
        {
            decimal first = (decimal)0.0278 * reps;
            decimal second = (decimal)1.0278 - first;
            decimal third = weight / second;


            // var calculatedOneRepMax = weight * (36 / (37 - reps));
            return (decimal)third;
        }

    }
}
