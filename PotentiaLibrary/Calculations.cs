using System;

namespace PotentiaLibrary
{
    public class Calculations
    {
        public static decimal BrzyckiFormula(int repetitions, decimal weight)
        {
            // Brzycki: weight × (36 / (37 - reps))
            // Calculates 1 rep max

            decimal a = (decimal)0.0278 * repetitions;
            decimal b = (decimal)1.0278 - a;
            decimal c = weight / b;

            return (decimal)c;
        }

        public static decimal EpleyFormula(int repetitions, decimal weight)
        {
            // Epley Formula: weight × (1 + 0.0333 × reps)
            // Calculates 1 rep max

            decimal a = (decimal)0.0333 * repetitions;
            decimal b = 1 + a;
            decimal c = weight * b;

            return (decimal)c;

        }

        public static decimal LanderFormula(int repetitions, decimal weight)
        {
            // Lander Formula: (100 × weight) / (101.3 - 2.67123 × reps)
            decimal a = weight * 100;
            decimal b = (decimal)2.67123 * repetitions;
            decimal c = (decimal)101.3 - b;
            decimal d = a / c;

            return (decimal)d;
        }

        public static decimal LombardiFormula(int repetitions, decimal weight)
        {
            // Lombardi Formula: weight × reps ^ 0.1
            // Calculates 1 rep max
            decimal a = (decimal)Math.Pow(repetitions, 0.1);
            decimal b = weight * a;
            return b;
        }

        public static decimal OConnerFormula(int repetitions, decimal weight)
        {
            // O'Conner Formula: weight × (1 + 0.025 × reps)
            // Calculates 1 rep max

            decimal a = (decimal)0.025 * repetitions;
            decimal b = 1 + a;
            decimal c = weight * b;

            return (decimal)c;
        }

    }
}
