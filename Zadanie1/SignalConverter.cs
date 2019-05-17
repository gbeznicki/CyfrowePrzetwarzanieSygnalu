using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;

namespace Zadanie1
{
    public static class SignalConverter
    {
        public static IEnumerable<DataPoint> SampleSignal(double samplingFrequency, List<DataPoint> signalValues, double signalDuration, double signalFreq)
        {
            if (samplingFrequency > signalFreq || signalFreq % samplingFrequency != 0)
                return null;

            var step = (int)(signalFreq / samplingFrequency);
            var samples = new DataPoint[(int)(samplingFrequency * signalDuration + 1)];

            for (int i = 0, j = 0; i < samples.Length - 1; ++i, j += step)
            {
                samples[i] = signalValues[j];
            }
            samples[samples.Length - 1] = signalValues[signalValues.Count - 1];
            return samples;
        }

        public static IEnumerable<DataPoint> QuantizeSignal(List<DataPoint> samples, int levels)
        {
            var results = new List<DataPoint>();
            double[] minMax = samples.GetMinMax(), 
                yValues = new double[levels];

            var step = Math.Abs(minMax[1] - minMax[0]) / levels;
            var closestIndex = 0;

            for (int i = 0; i < levels; ++i)
            {
                yValues[i] = minMax[0] + i * step;
            }

            foreach (var sample in samples)
            {
                for (int j = 1; j < levels; ++j)
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

        public static IEnumerable<DataPoint> SincReconstruction(int reconstructionFreq, int samplingFreq,
            double timeDuration, List<DataPoint> samples, int consideredSamplesAmount)
        {
            var xValues = SignalUtils.GetTimeValues(reconstructionFreq, timeDuration);
            var results = new List<DataPoint>();
            if (consideredSamplesAmount != 0)
            {
                foreach (var item in xValues)
                {
                    results.Add(new DataPoint(item, SignalUtils.GetSincReconstructionValue(samples.SegregateSamples(consideredSamplesAmount, item), item, samplingFreq)));
                }
            }
            else
            {
                foreach (var item in xValues)
                {
                    results.Add(new DataPoint(item, SignalUtils.GetSincReconstructionValue(samples, item, samplingFreq)));
                }
            }
            return results;
        }
    }
}