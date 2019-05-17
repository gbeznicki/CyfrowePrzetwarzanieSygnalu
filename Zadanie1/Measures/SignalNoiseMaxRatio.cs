using System;
using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public class SignalNoiseMaxRatio : IMeasure
    {
        public double GetValue(List<DataPoint> sincValues, List<DataPoint> signalValues)
        {
            List<DataPoint> values;
            if (sincValues.Count > signalValues.Count)
            {
                values = SignalUtils.AdjustSize(signalValues, sincValues.Count);
            }
            else if (sincValues.Count < signalValues.Count)
            {
                values = SignalUtils.AdjustSize(sincValues, signalValues.Count);
            }
            else
            {
                values = sincValues;
            }

            double mse = SignalUtils.GetMeanSquareError(sincValues, signalValues), numerator = values[0].Y;
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i].Y > numerator) numerator = values[i].Y;
            }

            return Math.Round(10 * Math.Log10(numerator / mse), 4);
        }
    }
}