using System;
using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public class SignalNoiseMaxRatio : IMeasure
    {
        public double GetValue(List<DataPoint> sincValues, List<DataPoint> sampledValues)
        {
            List<DataPoint> values;
            if (sincValues.Count > sampledValues.Count)
            {
                values = SignalUtils.AdjustSize(sampledValues, sincValues.Count);
            }
            else if (sincValues.Count < sampledValues.Count)
            {
                values = SignalUtils.AdjustSize(sincValues, sampledValues.Count);
            }
            else
            {
                values = sincValues;
            }

            double mse = SignalUtils.GetMeanSquareError(sincValues, sampledValues), numerator = values[0].Y;
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i].Y > numerator) numerator = values[i].Y;
            }

            return Math.Round(10 * Math.Log10(numerator / mse), 4);
        }
    }
}