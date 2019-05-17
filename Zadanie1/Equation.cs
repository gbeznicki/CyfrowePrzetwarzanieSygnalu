using OxyPlot;
using System;
using System.Collections.Generic;

namespace Zadanie1
{
    public class Equation
    {
        private readonly double amplitude = SharedSettings.Amplitude;
        private readonly double period = SharedSettings.Period;
        private readonly double initialTime = SharedSettings.InitialTime;
        private readonly double impletionRate = SharedSettings.ImpletionRate;
        private readonly double jumpTime = SharedSettings.JumpTime;
        private readonly double totalTime = SharedSettings.TotalTime;
        private readonly double frequency = SharedSettings.SamplingFrequency;
        private readonly double probability = SharedSettings.Probability;

        private Random random = new Random();

        public List<DataPoint> Sinus()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, amplitude * Math.Sin(Math.PI * 2.0 / period * (i - initialTime))));
            }
            return points;
        }

        public List<DataPoint> SinusWyprostowanyJednopolowkowo()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double sin = amplitude * Math.Sin(Math.PI * 2.0 / period * (i - initialTime));

                points.Add(new DataPoint(i, sin + Math.Abs(sin)));
            }
            return points;
        }

        public List<DataPoint> SinusWyprostowanyDwupolowkowo()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, Math.Abs(Math.Sin(Math.PI * 2.0 / period * (i - initialTime)))));
            }
            return points;
        }

        public List<DataPoint> SzumJednostajny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double range = 2 * amplitude;
                points.Add(new DataPoint(i, random.NextDouble() * range + (-amplitude)));

            }
            return points;
        }

        public List<DataPoint> SzumGaussowski()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                double range = 2 * amplitude;
                points.Add(new DataPoint(i, random.NextGaussian() * range + (-amplitude)));

            }
            return points;
        }

        public List<DataPoint> Prostokatny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;
            var k = 0;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= initialTime + (k + 1) * period)
                {
                    k++;
                }

                if (i >= k * period + initialTime && i < impletionRate * period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, amplitude));
                }
                else if (i >= impletionRate * period + k * period + initialTime && i < period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, 0));
                }
            }

            return points;

        }

        public List<DataPoint> ProstokatnySymetryczny()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;
            var k = 0;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= initialTime + (k + 1) * period)
                {
                    k++;
                }

                if (i >= k * period + initialTime && i < impletionRate * period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, amplitude));
                }
                if (i >= impletionRate * period + k * period + initialTime && i < period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, -amplitude));
                }
            }

            return points;
        }

        public List<DataPoint> SzumImpulsowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;
            var r = new Random();

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                points.Add(new DataPoint(i, r.NextDouble() < probability ? amplitude : 0.0));
            }

            return points;
        }

        public List<DataPoint> SkokJednostkowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i > jumpTime)
                {
                    points.Add(new DataPoint(i, amplitude));
                }
                else if (Math.Abs(i - jumpTime) < 1e-6)
                {
                    points.Add(new DataPoint(i, 0.5 * amplitude));
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
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;
            var k = 0;

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                if (i >= initialTime + (k + 1) * period)
                {
                    k++;
                }

                if (i >= k * period + initialTime && i < impletionRate * period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, amplitude / (impletionRate * period) * (i - k * period - initialTime)));
                }
                if (i >= impletionRate * period + k * period + initialTime && i < period + k * period + initialTime)
                {
                    points.Add(new DataPoint(i, ((-amplitude) / (period * (1 - impletionRate)) * (i - k * period - initialTime)) + (amplitude / (1 - impletionRate))));
                }
            }

            return points;
        }

        public List<DataPoint> ImpulsJednostkowy()
        {
            var points = new List<DataPoint>();
            var howManyPoints = totalTime * frequency;
            var span = 1.0 / frequency;
            var r = new Random();

            var i = initialTime;
            var j = 0;
            for (; j < howManyPoints; i += span, j++)
            {
                for (; j < howManyPoints; i += span, j++)
                {
                    points.Add(new DataPoint(i, Math.Abs(i - jumpTime) > 1e-6 ? 0.0 : amplitude));
                }
            }

            return points;
        }
    }
}