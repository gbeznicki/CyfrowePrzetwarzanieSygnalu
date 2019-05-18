using OxyPlot;
using System;
using System.Collections.Generic;

namespace Zadanie1
{
    public class EquationsProvider
    {
        public double Amplitude { get; set; }
        public double Period { get; set; }
        public double InitialTime { get; set; }
        public double ImpletionRate { get; set; }
        public double JumpTime { get; set; }
        public double TotalTime { get; set; }
        public double Frequency { get; set; }
        public double Probability { get; set; }

        private readonly Random random = new Random();

        public void InitializeValues(double amplitude, double period, double initialTime, double impletionRate,
            double jumpTime, double totalTime, double frequency, double probability)
        {
            Amplitude = amplitude;
            Period = period;
            InitialTime = initialTime;
            ImpletionRate = impletionRate;
            JumpTime = jumpTime;
            TotalTime = totalTime;
            Frequency = frequency;
            Probability = probability;
        }

        public List<DataPoint> Sinus()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, Amplitude * Math.Sin(Math.PI * 2.0 / Period * (i - InitialTime))));
            }
            return points;
        }

        public List<DataPoint> SinusWyprostowanyJednopolowkowo()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double sin = Amplitude * Math.Sin(Math.PI * 2.0 / Period * (i - InitialTime));

                points.Add(new DataPoint(i, sin + Math.Abs(sin)));
            }
            return points;
        }

        public List<DataPoint> SinusWyprostowanyDwupolowkowo()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, Math.Abs(Math.Sin(Math.PI * 2.0 / Period * (i - InitialTime)))));
            }
            return points;
        }

        public List<DataPoint> SzumJednostajny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double range = 2 * Amplitude;
                points.Add(new DataPoint(i, random.NextDouble() * range + (-Amplitude)));

            }
            return points;
        }

        public List<DataPoint> SzumGaussowski()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double range = 2 * Amplitude;
                points.Add(new DataPoint(i, random.NextGaussian() * range + (-Amplitude)));

            }
            return points;
        }

        public List<DataPoint> Prostokatny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;
            var k = 0;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= InitialTime + (k + 1) * Period)
                {
                    k++;
                }

                if (i >= k * Period + InitialTime && i < ImpletionRate * Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, Amplitude));
                }
                else if (i >= ImpletionRate * Period + k * Period + InitialTime && i < Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, 0));
                }
            }

            return points;

        }

        public List<DataPoint> ProstokatnySymetryczny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;
            var k = 0;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= InitialTime + (k + 1) * Period)
                {
                    k++;
                }

                if (i >= k * Period + InitialTime && i < ImpletionRate * Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, Amplitude));
                }
                if (i >= ImpletionRate * Period + k * Period + InitialTime && i < Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, -Amplitude));
                }
            }

            return points;
        }

        public List<DataPoint> SzumImpulsowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;
            var r = new Random();

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, r.NextDouble() < Probability ? Amplitude : 0.0));
            }

            return points;
        }

        public List<DataPoint> SkokJednostkowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i > JumpTime)
                {
                    points.Add(new DataPoint(i, Amplitude));
                }
                else if (Math.Abs(i - JumpTime) < 1e-6)
                {
                    points.Add(new DataPoint(i, 0.5 * Amplitude));
                }
                else
                {
                    points.Add(new DataPoint(i, 0));
                }
            }
            return points;
        }

        public List<DataPoint> Trojkatny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;
            var k = 0;

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= InitialTime + (k + 1) * Period)
                {
                    k++;
                }

                if (i >= k * Period + InitialTime && i < ImpletionRate * Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, Amplitude / (ImpletionRate * Period) * (i - k * Period - InitialTime)));
                }
                if (i >= ImpletionRate * Period + k * Period + InitialTime && i < Period + k * Period + InitialTime)
                {
                    points.Add(new DataPoint(i, ((-Amplitude) / (Period * (1 - ImpletionRate)) * (i - k * Period - InitialTime)) + (Amplitude / (1 - ImpletionRate))));
                }
            }

            return points;
        }

        public List<DataPoint> ImpulsJednostkowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = TotalTime * Frequency;
            var span = 1.0 / Frequency;
            var r = new Random();

            var i = InitialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                for (; j < howManyPoints; i += span, j++)
                {
                    points.Add(new DataPoint(i, Math.Abs(i - JumpTime) > 1e-6 ? 0.0 : Amplitude));
                }
            }

            return points;
        }
    }
}