using System;
using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public class MeanSquareError : IMeasure
    {
        public double GetValue(List<DataPoint> sincValues, List<DataPoint> sampledValues)
        {
            List<DataPoint> valuesOne, valuesTwo;

            if (sincValues.Count > sampledValues.Count)
            {
                valuesOne = sincValues;
                valuesTwo = SignalUtils.AdjustSize(sampledValues, sincValues.Count);
            }
            else if (sincValues.Count < sampledValues.Count)
            {
                valuesOne = sampledValues;
                valuesTwo = SignalUtils.AdjustSize(sincValues, sampledValues.Count);
            }
            else
            {
                valuesOne = sampledValues;
                valuesTwo = sincValues;
            }

            double fraction = 1.0 / valuesOne.Count, sum = 0;
            for (int i = 0; i < valuesOne.Count; i++)
            {
                sum += Math.Pow(valuesOne[i].Y - valuesTwo[i].Y, 2);
            }
            return Math.Round(fraction * sum, 4);
        }
    }
}