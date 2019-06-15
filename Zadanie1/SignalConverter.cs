using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace Zadanie1
{
    public static class SignalConverter
    {
        static readonly List<IMeasure> Measures = new List<IMeasure>()
        {
            new MeanSquareError(),
            new SignalNoiseRatio(),
            new SignalNoiseMaxRatio(),
            new MaxDifference(),
        };

        #region A/C

        public static IEnumerable<ScatterPoint> SampleSignal(List<DataPoint> signal, double samplingFrequency, int samplingFrequencyAc,
            out List<double> measuredValues)
        {
            measuredValues = null;
            if (Math.Abs(samplingFrequency % samplingFrequencyAc) > 0.00001) return new List<ScatterPoint>();
            var results = new List<ScatterPoint>();
            var stepSize = (int)samplingFrequency / samplingFrequencyAc;
            for (int i = 0; i < signal.Count; i += stepSize)
            {
                var point = signal[i];
                results.Add(new ScatterPoint(point.X, point.Y));
            }

            measuredValues = Measures.Select(m => m.GetValue(signal, results.Select(p => new DataPoint(p.X, p.Y)).ToList())).ToList();
            return results;
        }

        public static IEnumerable<DataPoint> QuantizeSignal(List<DataPoint> samples, int quantizationLevel, out List<double> measuredValues)
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

            measuredValues = Measures.Select(m => m.GetValue(results, samples)).ToList();

            return results;
        }

        #endregion

        #region C/A

        public static IEnumerable<DataPoint> ZeroAndHoldExtrapolation(List<ScatterPoint> sampledSignal,
            double samplingFrequency, int samplesNum = 8)
        {
            var reconstructedPoints = new List<DataPoint>();
            var min = sampledSignal.Min(p => p.X);
            var max = sampledSignal.Max(p => p.X);
            var interval = (max - min) / 5000;
            var t = 1.0 / samplingFrequency;
            for (var i = min; i <= max; i += interval)
            {
                var sum = 0.0;
                for (int j = 0; j < sampledSignal.Count; ++j)
                {
                    sum += sampledSignal[j].Y * ((i - t / 2 - j * t) / t).Rect();
                }
                reconstructedPoints.Add(new DataPoint(i, sum));
            }
            return reconstructedPoints;
        }

        //public static IEnumerable<DataPoint> ZeroAndHoldExtrapolation(List<ScatterPoint> sampledPoints, double samplingFreq, double initialTime, 
        //    int samplingFreqAc, int originalSignalLength, out List<double> measuredValues)
        //{
        //    var extrapolatedValues = new List<DataPoint>();
        //    var sampledValues = sampledPoints.Select(p => p.Y).ToList();
        //    var T = 1 / (double)samplingFreqAc;
        //    for (int i = 0; i < originalSignalLength; i++)
        //    {
        //        double sum = 0;
        //        var t = i / samplingFreq + initialTime;
        //        for (int j = 0; j < sampledValues.Count; j++)
        //        {
        //            var rect = Rect((t - (T / 2.0) - (j * T)) / T);
        //            sum += sampledValues[j] * rect;
        //        }
        //        extrapolatedValues.Add(new DataPoint(t, sum));
        //    }

        //    var sampledPointsAsData = sampledPoints.Select(point => new DataPoint(point.X, point.Y)).ToList();
        //    measuredValues = Measures.Select(m => m.GetValue(extrapolatedValues, sampledPointsAsData)).ToList();

        //    return extrapolatedValues;
        //}

        //public static IEnumerable<DataPoint> SincReconstruction(int reconstructionFreq, double samplingFreq,
        //    double timeDuration, List<ScatterPoint> sampledPoints, int consideredSamplesAmount, out List<double> measuredValues)
        //{
        //    var xValues = SignalUtils.GetTimeValues(reconstructionFreq, timeDuration);
        //    var results = new List<DataPoint>();
        //    if (consideredSamplesAmount != 0)
        //    {
        //        foreach (var item in xValues)
        //        {
        //            results.Add(new DataPoint(item,
        //                SignalUtils.GetSincReconstructionValue(
        //                    sampledPoints.SegregateSamples(consideredSamplesAmount, item), item, samplingFreq)));
        //        }
        //    }
        //    else
        //    {
        //        foreach (var item in xValues)
        //        {
        //            results.Add(new DataPoint(item, SignalUtils.GetSincReconstructionValue(sampledPoints, item, samplingFreq)));
        //        }
        //    }

        //    var sampledPointsAsData = sampledPoints.Select(point => new DataPoint(point.X, point.Y)).ToList();
        //    measuredValues = Measures.Select(m => m.GetValue(results, sampledPointsAsData)).ToList();

        //    return results;
        //}

        //public static IEnumerable<DataPoint> Interpolate(int originaSignalLength, IEnumerable<ScatterPoint> sampledPoints,
        //    double samplingFrequency, double samplingFrequencyAc, double initialTime, out List<double> measuredValues)
        //{
        //    var results = new List<DataPoint>();
        //    var T = 1 / samplingFrequencyAc;
        //    var scatterPoints = sampledPoints.ToList();
        //    var sampledValues = scatterPoints.Select(point => point.Y).ToList();

        //    for (int i = 0; i < originaSignalLength; i++)
        //    {
        //        var t = i / samplingFrequency + initialTime;
        //        double sum = 0;
        //        for (int j = 0; j < sampledValues.Count; j++)
        //        {
        //            var tri = Tri((t - j * T) / T);
        //            sum += sampledValues[j] * tri;
        //        }
        //        results.Add(new DataPoint(t, sum));
        //    }

        //    var sampledPointsAsData = scatterPoints.Select(point => new DataPoint(point.X, point.Y)).ToList();
        //    measuredValues = Measures.Select(m => m.GetValue(results, sampledPointsAsData)).ToList();

        //    return results;
        //}

        //static double Tri(double t)
        //{
        //    if (Math.Abs(t) < 1.0)
        //    {
        //        return 1.0 - Math.Abs(t);
        //    }
        //    return 0.0;
        //}

        public static IEnumerable<DataPoint> SincReconstruction(List<ScatterPoint> signal, double samplingFreq, int samplesNum = 8)
        {
            var reconstructedPoints = new List<DataPoint>();
            var min = signal.Min(p => p.X);
            var max = signal.Max(p => p.X);
            var interval = (max - min) / 2001;

            var T = 1.0 / samplingFreq;
            for (double i = min; i <= max; i += interval)
            {
                double sum = 0;
                var between = GetIntervalIndex(signal.Select(p => p.X).ToList(), i);
                if (between.Item1 == between.Item2)
                {
                    sum = signal[between.Item1].Y;
                }
                else
                {
                    var start = between.Item1 - samplesNum;
                    var end = between.Item2 + samplesNum;

                    if (start < 0)
                    {
                        start = 0;
                    }

                    if (end > signal.Count - 1)
                    {
                        end = signal.Count - 1;
                    }

                    for (int j = start; j <= end; j++)
                    {
                        var test = i / T - j;
                        var test1 = GetSincValue(test);
                        sum += signal[j].Y * test1;
                    }
                }
                reconstructedPoints.Add(new DataPoint(i, sum));
            }
            return reconstructedPoints;
        }

        public static double GetSincValue(double value)
        {
            if (value.Equals(0)) return 1;
            return Math.Sin(Math.PI * value) / (Math.PI * value);
        }

        //public static List<(double, double)> ExtendSignal(List<(double, double)> signal)
        //{
        //    double val = signal.Last().Item1;
        //    var temp = signal.Skip(1).Select(c => (c.Item1 + val, c.Item2)).ToList();
        //    signal.AddRange(temp);
        //    return signal;
        //}

        static Tuple<int, int> GetIntervalIndex(List<double> values, double value)
        {
            for (int i = 0; i < values.Count - 1; i++)
            {
                if (value > values[i] && value < values[i + 1])
                {
                    return new Tuple<int, int>(i, i + 1);
                }

                if (values[i].Equals(value))
                {
                    return new Tuple<int, int>(i, i);
                }
            }
            return new Tuple<int, int>(0, 1);
        }
        #endregion
    }
}