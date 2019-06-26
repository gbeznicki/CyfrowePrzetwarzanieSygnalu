using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Zadanie3
{
    public class Window
    {
        public static List<DataPoint> BlackmanWindow(List<DataPoint> filterDataPoints, int m)
        {
            var result = new List<DataPoint>();

            for (var i = 0; i < filterDataPoints.Count; i++)
            {
                double factor = 0.42 - (0.5 * Math.Cos(2 * Math.PI * i / m)) + (0.08 * Math.Cos(4 * Math.PI * i / m));
                result.Add(new DataPoint(filterDataPoints[i].X, factor * filterDataPoints[i].Y));
            }

            return result;
        }

        public static List<DataPoint> RectangularWindow(List<DataPoint> filterDataPoints, int m)
        {
            return filterDataPoints;
        }

        public static List<DataPoint> HammingWindow(List<DataPoint> filterDataPoints, int m)
        {
            var result = new List<DataPoint>();

            for (var i = 0; i < filterDataPoints.Count; i++)
            {
                double factor = 0.53836 - (0.46164 * Math.Cos(2 * Math.PI * i / m));
                result.Add(new DataPoint(filterDataPoints[i].X, factor * filterDataPoints[i].Y));
            }

            return result;
        }

        public static List<DataPoint> HanningWindow(List<DataPoint> filterDataPoints, int m)
        {
            var result = new List<DataPoint>();

            for (var i = 0; i < filterDataPoints.Count; i++)
            {
                double factor = 0.5 - (0.5 * Math.Cos(2 * Math.PI * i / m));
                result.Add(new DataPoint(filterDataPoints[i].X, factor * filterDataPoints[i].Y));
            }

            return result;
        }
    }
}
