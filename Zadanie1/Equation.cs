using OxyPlot;
using System;
using System.Collections.Generic;

namespace Zadanie1
{
    internal class Equation
    {
        public double Amplitude { get; set; }
        public double Period { get; set; }
        public double InitialTime { get; set; }
        public double ImpletionRate { get; set; }
        public double JumpTime { get; set; }

        private Random random = new Random();

        public double Sinus(double x)
        {
            return Amplitude * Math.Sin(Math.PI * 2.0 / Period * (x - InitialTime));
        }

        public double SinusWyprostowanyJednopolowkowo(double x)
        {
            double sin = Amplitude * Math.Sin(Math.PI * 2.0 / Period * (x - InitialTime));

            return sin + Math.Abs(sin);
        }

        public double SinusWyprostowanyDwupolowkowo(double x)
        {
            return Amplitude * Math.Abs(Math.Sin(Math.PI * 2.0 / Period * (x - InitialTime)));
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

        public List<DataPoint> Prostokatny(double duration, double samplingFrequency, double beginsAt, double period, double fillFactor, double amplitude)
        {
            var points = new List<DataPoint>();
            var howManyPoints = duration * samplingFrequency;
            var span = 1.0 / samplingFrequency;
            var k = 0;

            var i = beginsAt;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= beginsAt + (k + 1) * period)
                    k++;
                if (i >= k * period + beginsAt && i < fillFactor * period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i, amplitude));
                }
                else if (i >= fillFactor * period + k * period + beginsAt && i < period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i, 0));
                }
            }

            return points;

        }

        public List<DataPoint> ProstokatnySymetryczny(double duration, double samplingFrequency, double beginsAt, double period, double fillFactor, double amplitude)
        {
            var points = new List<DataPoint>();
            var howManyPoints = duration * samplingFrequency;
            var span = 1.0 / samplingFrequency;
            var k = 0;

            var i = beginsAt;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= beginsAt + (k + 1) * period)
                    k++;
                if (i >= k * period + beginsAt && i < fillFactor * period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i, amplitude));
                }
                if (i >= fillFactor * period + k * period + beginsAt && i < period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i, -amplitude));
                }
            }

            return points;
        }

        public double SkokJednostkowy(double x)
        {
            if (x > JumpTime)
                return Amplitude;
            else if (Math.Abs(x - JumpTime) < 1e-6)
                return 0.5 * Amplitude;
            else
                return 0;
        }

        public List<DataPoint> Trojkatny(double duration, double samplingFrequency, double beginsAt, double period, double fillFactor, double amplitude)
        {
            var points = new List<DataPoint>();
            var howManyPoints = duration * samplingFrequency;
            var span = 1.0 / samplingFrequency;
            var k = 0;

            var i = beginsAt;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= beginsAt + (k + 1) * period)
                    k++;
                if (i >= k * period + beginsAt && i < fillFactor * period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i,amplitude / (fillFactor * period) * (i - k * period - beginsAt)));
                }
                if (i >= fillFactor * period + k * period + beginsAt && i < period + k * period + beginsAt)
                {
                    points.Add(new DataPoint(i,((-amplitude) / (period * (1 - fillFactor)) * (i - k * period - beginsAt)) + (amplitude / (1 - fillFactor))));
                }
            }

            return points;
        }
    }
}