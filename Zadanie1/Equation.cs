using System;

namespace Zadanie1
{
    internal class Equation
    {
        public double Amplitude { get; set; }
        private Random random = new Random();

        public double SzumJednostajny(double x)
        {
            double range = 2 * Amplitude;
            double result = random.NextDouble() * range + (-Amplitude);
            return result;
        }

        public double SzumGaussowski(double x)
        {
            double range = 2 * Amplitude;
            double result = random.NextGaussian() * range + (-Amplitude);
            return result;
        }

    }
}