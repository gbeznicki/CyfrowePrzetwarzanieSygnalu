using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace Zadanie1
{
    public static class SignalConverter
    {
        #region A/C

        public static IEnumerable<ScatterPoint> SampleSignal(List<DataPoint> signal, double samplingFrequency, int samplingFrequencyAc)
        {
            if (Math.Abs(samplingFrequency % samplingFrequencyAc) > 0.00001) return new List<ScatterPoint>();
            var results = new List<ScatterPoint>();
            var stepSize = (int)samplingFrequency / samplingFrequencyAc;
            for (int i = 0; i < signal.Count; i += stepSize)
            {
                var point = signal[i];
                results.Add(new ScatterPoint(point.X, point.Y));
            }
            return results;
        }

        public static IEnumerable<DataPoint> QuantizeSignal(List<DataPoint> samples, int quantizationLevel)
        {
            var results = new List<DataPoint>();
            var minMax = samples.GetMinMax();

            var yValues = new List<double>(quantizationLevel) { minMax[1], minMax[0] };

            var step = Math.Abs(minMax[1] - minMax[0]) / (quantizationLevel - 1);
            var closestIndex = 0;

            if (quantizationLevel > 2)
            {
                for (int i = 1; i <= quantizationLevel - 2; ++i)
                {
                    yValues.Add(minMax[1] - step * i);
                }
            }

            foreach (var sample in samples)
            {
                for (int j = 0; j < quantizationLevel; ++j)
                {
                    if (Math.Abs(yValues[j] - sample.Y) < Math.Abs(yValues[closestIndex] - sample.Y))
                    {
                        closestIndex = j;
                    }
                }
                results.Add(new DataPoint(sample.X, yValues[closestIndex]));
                closestIndex = 0;
            }

            return results;
        }

        #endregion

        #region C/A

        public static IEnumerable<DataPoint> SincReconstruction(int reconstructionFreq, double samplingFreq,
            double timeDuration, List<ScatterPoint> sampledPoints, int consideredSamplesAmount, out List<double> measuredValues)
        {
            var xValues = SignalUtils.GetTimeValues(reconstructionFreq, timeDuration);
            var results = new List<DataPoint>();
            if (consideredSamplesAmount != 0)
            {
                foreach (var item in xValues)
                {
                    results.Add(new DataPoint(item, 
                        SignalUtils.GetSincReconstructionValue(
                            sampledPoints.SegregateSamples(consideredSamplesAmount, item), item, samplingFreq)));
                }
            }
            else
            {
                foreach (var item in xValues)
                {
                    results.Add(new DataPoint(item, SignalUtils.GetSincReconstructionValue(sampledPoints, item, samplingFreq)));
                }
            }

            var sampledPointsAsData = sampledPoints.Select(point => new DataPoint(point.X, point.Y)).ToList();
            measuredValues = new List<double>()
            {
                new MaxDifference().GetValue(results, sampledPointsAsData),
                new MeanSquareError().GetValue(results, sampledPointsAsData),
                new SignalNoiseMaxRatio().GetValue(results, sampledPointsAsData),
                new SignalNoiseRatio().GetValue(results, sampledPointsAsData),
            };

            return results;
        }

        public static IEnumerable<DataPoint> Interpolate(int originaSignalLength, IEnumerable<ScatterPoint> sampledPoints,
            double samplingFrequency, double samplingFrequencyAc, double initialTime, out List<double> measuredValues)
        {
            var results = new List<DataPoint>();
            var T = 1 / samplingFrequencyAc;
            var scatterPoints = sampledPoints.ToList();
            var sampledValues = scatterPoints.Select(point => point.Y).ToList();

            for (int i = 0; i < originaSignalLength; i++)
            {
                var t = i / samplingFrequency + initialTime;
                double sum = 0;
                for (int j = 0; j < sampledValues.Count; j++)
                {
                    var tri = Tri((t - j * T) / T);
                    sum += sampledValues[j] * tri;
                }
                results.Add(new DataPoint(t, sum));
            }

            var sampledPointsAsData = scatterPoints.Select(point => new DataPoint(point.X, point.Y)).ToList();
            measuredValues = new List<double>()
            {
                new MaxDifference().GetValue(results, sampledPointsAsData),
                new MeanSquareError().GetValue(results, sampledPointsAsData),
                new SignalNoiseMaxRatio().GetValue(results, sampledPointsAsData),
                new SignalNoiseRatio().GetValue(results, sampledPointsAsData),
            };

            return results;
        }

        static double Tri(double t)
        {
            if (Math.Abs(t) < 1.0)
            {
                return 1.0 - Math.Abs(t);
            }
            return 0.0;
        }

        #endregion
    }
}