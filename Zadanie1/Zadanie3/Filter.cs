using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace Zadanie1.Zadanie3
{
    public class Filter
    {
        private static List<DataPoint> useWindow(List<DataPoint> filterDataPoints, int m)
        {
            List<DataPoint> results = new List<DataPoint>();
            switch (SharedSettings.ChosenWindow)
            {
                case "Hamminga":
                    results = Window.HammingWindow(filterDataPoints, m);
                    break;
                case "Hanninga":
                    results = Window.HanningWindow(filterDataPoints, m);
                    break;
                case "Blackmana":
                    results = Window.BlackmanWindow(filterDataPoints, m);
                    break;
                default:
                    results = Window.RectangularWindow(filterDataPoints, m);
                    break;
            }
            return results;
        }

        public static List<DataPoint> LowPassFilter(int m, double fo, double fp)
        {
            var results = new List<DataPoint>();
            double K = fp / fo;
            int center = (m - 1) / 2;

            for (int n = 0; n < m; n++)
            {
                double factor;
                if (n == center)
                {
                    factor = 2.0 / K;
                }
                else
                {
                    factor = Math.Sin(2 * Math.PI * (n - center) / K) / (Math.PI * (n - center));
                }

                results.Add(new DataPoint(n, factor));
            }

            return useWindow(results, m);
        }

        public static List<DataPoint> MidPassFilter(int m, double fo, double fp)
        {
            List<DataPoint> results = new List<DataPoint>();
            List<DataPoint> lowPassResults = LowPassFilter(m, fo, fp);

            for (int i = 0; i < lowPassResults.Count; i++)
            {
                results.Add(new DataPoint(lowPassResults[i].X, lowPassResults[i].Y * 2 * Math.Sin(Math.PI * i / 2.0)));
            }

            return useWindow(results, m);
        }

        public static List<DataPoint> HighPassFilter(int m, double fo, double fp)
        {
            List<DataPoint> results = new List<DataPoint>();
            List<DataPoint> lowPassResults = LowPassFilter(m, 1000 - fo, fp);

            for (int i = 0; i < lowPassResults.Count; i++)
            {
                results.Add(new DataPoint(lowPassResults[i].X, lowPassResults[i].Y * (i % 2 == 0 ? 1 : -1)));
            }

            return useWindow(results, m);
        }
    }
}
