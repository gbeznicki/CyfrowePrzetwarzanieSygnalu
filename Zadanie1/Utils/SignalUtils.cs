using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace Zadanie1
{
    public static class SignalUtils
    {
        public static double[] GetMinMax(this List<DataPoint> samples)
        {
            var result = new[] { samples[0].Y, samples[0].Y };
            for (int i = 1; i < samples.Count; ++i)
            {
                if (samples[i].Y > result[1])
                    result[1] = samples[i].Y;
                else if (samples[i].Y < result[0])
                    result[0] = samples[i].Y;
            }
            return result;
        }

        public static double GetMeanSquareError(List<DataPoint> sincValues, List<DataPoint> signalValues)
        {
            List<DataPoint> valuesOne, valuesTwo;
            if (sincValues.Count > signalValues.Count)
            {
                valuesOne = sincValues;
                valuesTwo = AdjustSize(signalValues, sincValues.Count);
            }
            else if (sincValues.Count < signalValues.Count)
            {
                valuesOne = signalValues;
                valuesTwo = AdjustSize(sincValues, signalValues.Count);
            }
            else
            {
                valuesOne = signalValues;
                valuesTwo = sincValues;
            }

            double fraction = 1.0 / valuesOne.Count, sum = 0;
            for (int i = 0; i < valuesOne.Count; i++)
            {
                sum += Math.Pow(valuesOne[i].Y - valuesTwo[i].Y, 2);
            }
            return Math.Round(fraction * sum, 4);
        }

        public static double[] GetTimeValues(int signalFrequency, double timeDuration, double startTime = 0)
        {
            var result = new double[(int)(timeDuration / (1.0 / signalFrequency) + 1.0)];
            var step = 1.0 / signalFrequency;
            result[0] = startTime;
            for (int i = 1; i < result.Length; ++i)
            {
                result[i] = result[i - 1] + step;
            }
            return result;
        }

        public static double GetSincReconstructionValue(IEnumerable<ScatterPoint> samples, double time, double frequency)
        {
            double result = 0.0, T = 1.0 / frequency;
            foreach (var sample in samples)
            {
                var val = time / T - sample.X / T;
                result += sample.Y * Sinc(val);
            }
            return result;
        }

        static double Sinc(double p)
        {
            return p == 0.0 ? 1.0 : Math.Sin(Math.PI * p) / (Math.PI * p);
        }

        public static IEnumerable<ScatterPoint> SegregateSamples(this List<ScatterPoint> samples, int consideredSamplesAmount, double time)
        {
            return samples.OrderBy(s => (Math.Abs(s.X - time))).Take(consideredSamplesAmount * 2);
        }

        public static List<DataPoint> AdjustSize(List<DataPoint> values, int size)
        {
            var results = new List<DataPoint>();
            foreach (var item in values)
            {
                for (int j = 0; j < (size / values.Count + 1); j++)
                {
                    results.Add(new DataPoint(item.X, item.Y));
                }
            }
            return results;
        }
    }
}