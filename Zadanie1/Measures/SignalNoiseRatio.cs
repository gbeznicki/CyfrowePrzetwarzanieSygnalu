using System;
using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public class SignalNoiseRatio : IMeasure
    {
        public double GetValue(List<DataPoint> sincValues, List<DataPoint> signalValues)
        {
            List<DataPoint> sinc, signal;
            if (sincValues.Count > signalValues.Count)
            {
                sinc = sincValues;
                signal = SignalUtils.AdjustSize(signalValues, sincValues.Count);
            }
            else if (sincValues.Count < signalValues.Count)
            {
                signal = signalValues;
                sinc = SignalUtils.AdjustSize(sincValues, signalValues.Count);
            }
            else
            {
                signal = signalValues;
                sinc = sincValues;
            }

            double numerator = 0, denominator = 0;

            for (int i = 0; i < sinc.Count; i++)
            {
                numerator += Math.Pow(signal[i].Y, 2);
                denominator += Math.Pow(signal[i].Y - sinc[i].Y, 2);
            }

            return Math.Round(10 * Math.Log10(numerator / denominator), 4);
        }
    }
}