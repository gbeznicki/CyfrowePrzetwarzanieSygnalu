using System.Collections.Generic;
using OxyPlot;

namespace Zadanie1
{
    public interface IMeasure
    {
        double GetValue(List<DataPoint> sincValues, List<DataPoint> sampledValues);
    }
}