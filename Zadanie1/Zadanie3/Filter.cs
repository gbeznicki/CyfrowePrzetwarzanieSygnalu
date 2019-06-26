using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;
using Zadanie1.Zadanie3.Filters;
using Zadanie1.Zadanie3.Windows;
using Zadanie1.Zadanie3.Convolution;

namespace Zadanie1.Zadanie3
{
    public class Filter
    {
        //private IImpulseResponse _response;
        //private IWindow _window;

        //public Filter ImpulseResponse(IImpulseResponse response)
        //{
        //    _response = response;
        //    return this;
        //}

        //public Filter WindowFunction(IWindow window)
        //{
        //    _window = window;
        //    return this;
        //}

        public static List<DataPoint> LowPassFilter(int m, double fo, double fp)
        {
            var results = new List<DataPoint>();
            //List<double> result = new List<double>();
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
                //result.Add(factor);

                results.Add(new DataPoint(n, factor));
            }

            return results;
        }

        //public List<double> FilterOperation(List<double> points, int m, double fo, double fp)
        //{
        //    if (_response == null)
        //        throw new Exception("Response is null");
        //    return Helper.Convolution(_response.Create(points.Count, m, fo, fp).Zip((_window ?? new RectangularWindow()).Create(points.Count, m), (x, y) => x * y).ToList(), points);
        //}

        //public List<double> FilterOperation2(List<double> points, int m, double fo, double fp)
        //{
        //    if (_response == null)
        //        throw new Exception("Response is null");
        //    return _response.Create(points.Count, m, fo, fp).Zip((_window ?? new RectangularWindow()).Create(points.Count, m), (x, y) => x * y).ToList();
        //}
    }
}
