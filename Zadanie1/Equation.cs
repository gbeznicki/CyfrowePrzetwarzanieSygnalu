using System;

namespace Zadanie1
{
    internal class Equation
    {
        public double Amplitude { get; set; }
        public double Period { get; set; }
        public double InitialTime { get; set; }

        private Random random = new Random();

        public double Sinus(double x)
        {
            return Amplitude * Math.Sin(Math.PI * 2.0 / Period * (x - InitialTime));
        }

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