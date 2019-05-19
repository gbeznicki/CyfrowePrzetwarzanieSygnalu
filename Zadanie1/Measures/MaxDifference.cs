using System;
using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public class MaxDifference : IMeasure
    {
        public double GetValue(List<DataPoint> sincValues, List<DataPoint> sampledValues)
        {
            List<DataPoint> sinc, signal;
            if (sincValues.Count > sampledValues.Count)
            {
                sinc = sincValues;
                signal = SignalUtils.AdjustSize(sampledValues, sincValues.Count);
            }
            else if (sincValues.Count < sampledValues.Count)
            {
                signal = sampledValues;
                sinc = SignalUtils.AdjustSize(sincValues, sampledValues.Count);
            }
            else
            {
                signal = sampledValues;
                sinc = sincValues;
            }

            var diff = Math.Abs(sinc[0].Y - signal[0].Y);
            for (int i = 1; i < sinc.Count; i++)
            {
                if (diff < Math.Abs(sinc[i].Y - signal[i].Y))
                {
                    diff = Math.Abs(sinc[i].Y - signal[i].Y);
                }
            }
            return Math.Round(diff, 4);
        }
    }
}