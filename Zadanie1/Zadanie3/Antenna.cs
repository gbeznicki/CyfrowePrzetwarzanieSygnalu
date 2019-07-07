using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Zadanie3
{
    public class Antenna
    {
        private static readonly Random Random = new Random();

        public int NumberOfMeasurement { get; set; }
        public double TimeUnit { get; set; }
        public double RealSpeed { get; set; }
        public double AbstractSpeed { get; set; }
        public double SignalPeriod { get; set; }
        public int BasicSignals { get; set; }
        public double SamplingFrequency { get; set; }
        public double BuffersLength { get; set; }
        public double ReportingPeriod { get; set; }

        public List<double> ProbingSignal { get; set; }
        public List<double> FeedbackSignal { get; set; }
        public List<double> CorrelationSamples { get; set; }
        
        public Antenna()
        {
            NumberOfMeasurement = SharedSettings.NumberOfMeasurement;
            TimeUnit = SharedSettings.TimeUnit;
            RealSpeed = SharedSettings.RealSpeed;
            AbstractSpeed = SharedSettings.AbstractSpeed;
            SignalPeriod = SharedSettings.SignalPeriod;
            BasicSignals = SharedSettings.BasicSignals;
            SamplingFrequency = SharedSettings.SamplingFrequency;
            BuffersLength = SharedSettings.BuffersLength;
            ReportingPeriod = SharedSettings.ReportingPeriod;
        }

        public List<double> GetOriginalDistance()
        {
            List<double> result = new List<double>();

            for (double i = 0.0; i < (double)(NumberOfMeasurement) * ReportingPeriod; i += ReportingPeriod)
                result.Add(i * RealSpeed);

            return result;
        }

        public List<double> CountDiffrence(List<double> originalDistance, List<double> countedDistance)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < originalDistance.Count; i++)
                result.Add(Math.Round(Math.Abs(originalDistance[i] - countedDistance[i]), 6));

            return result;
        }

        public List<double> CountDistances()
        {
            List<double> result = new List<double>();
            List<double> amplitudes = new List<double>();

            for (int i = 0; i < BasicSignals; i++)
            {
                amplitudes.Add(Random.NextDouble() * 5.0 + 1.0);
            }

            double duration = BuffersLength / SamplingFrequency;

            for (double i = 0.0; i < (double)(NumberOfMeasurement) * ReportingPeriod; i += ReportingPeriod)
            {
                double currentDistance = i * RealSpeed;
                double propagationTime = 2 * currentDistance / AbstractSpeed;

                ProbingSignal = CreateSignal(amplitudes, SignalPeriod, i - duration, duration, SamplingFrequency);
                FeedbackSignal = CreateSignal(amplitudes, SignalPeriod, i - propagationTime, duration, SamplingFrequency);

                CorrelationSamples = IndirectlyCorelateSignals(ProbingSignal, FeedbackSignal);

                result.Add(CalculateDistance(CorrelationSamples, SamplingFrequency, AbstractSpeed));
            }

            return result;
        }

        private static double CalculateDistance(List<double> correlation, double frequency, double abstractSpeed)
        {
            var rightHalf = correlation.Skip(correlation.Count / 2).ToList();
            var maxSample = rightHalf.IndexOf(rightHalf.Max());
            var tDelay = maxSample / frequency;

            return Math.Round(((tDelay * abstractSpeed) / 2), 6);
        }


        private List<double> CreateSignal(List<double> amplitudes, double period, double startTime, double duration, double frequency)
        {
            List<double> samples = new List<double>();

            for (int i = 0; i < 1; i++)
            {
                List<double> newSamples = new List<double>();

                for (decimal j = (decimal)startTime; j < (decimal)(startTime + duration); j += 1 / (decimal)frequency)
                {
                    newSamples.Add(AntenaSinusoidalSignal(amplitudes[i], period, (double)j));
                }

                if (samples.Count != 0)
                    samples = AddSignals(newSamples, samples);
                else
                    samples = newSamples;
            }

            return samples;
        }

        // no start time, so no T1
        private double AntenaSinusoidalSignal(double A, double T, double t)
        {
            return A * Math.Sin((2 * Math.PI / T) * t);
        }

        public static List<double> IndirectlyCorelateSignals(List<double> signal1, List<double> signal2)
        {
            signal1.Reverse();
            return ConvoluteSignals(signal1, signal2);
        }
        public static List<double> ConvoluteSignals(List<double> signal1, List<double> signal2)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < signal1.Count + signal2.Count - 1; i++)
            {
                double sum = 0;
                for (int j = 0; j < signal1.Count; j++)
                {
                    if (i - j < 0 || i - j >= signal2.Count)
                        continue;

                    sum += signal1[j] * signal2[i - j];
                }
                result.Add(sum);
            }

            return result;
        }
        public static List<double> AddSignals(List<double> signal1, List<double> signal2)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < Math.Max(signal1.Count, signal2.Count); i++)
            {

                result.Add(signal1[i] + signal2[i]);
            }

            return result;
        }
    }
}
