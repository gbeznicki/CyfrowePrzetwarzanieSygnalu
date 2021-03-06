﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Accord.Math.Transforms;


namespace Zadanie1
{
    class FourierTransform
    {
        public static List<Complex> Transform(List<double> points)
        {
            List<Complex> transformed = new List<Complex>();
            int N = points.Count;
            for (int i = 0; i < points.Count; i++)
            {
                Complex transformedValue = Complex.Zero;
                for (int j = 0; j < points.Count; j++)
                {
                    transformedValue += points[j] * Complex.Exp(new Complex(0, -2 * Math.PI * i * j / N));
                }
                transformed.Add(transformedValue / N);
            }
            return transformed;
        }
        public static List<double> ReverseTransform(List<Complex> points)
        {
            List<double> transformed = new List<double>();

            int N = points.Count;
            for (int i = 0; i < points.Count; i++)
            {
                double transformedValue = 0;
                for (int j = 0; j < points.Count; j++)
                {
                    transformedValue += (points[j] * Complex.Exp(new Complex(0, 2 * Math.PI * i * j / N))).Real;
                }
                transformed.Add(transformedValue);
            }
            return transformed;
        }

        public static List<Complex> FastFourierTransformation(Complex[] data)
        {
            FourierTransform2.FFT(data, Accord.Math.FourierTransform.Direction.Forward);
            return data.OfType<Complex>().ToList();
        }

        public static List<Complex> InverseFastFourierTransformation(Complex[] data)
        {
            FourierTransform2.FFT(data, Accord.Math.FourierTransform.Direction.Backward);
            return data.OfType<Complex>().ToList();
        }

        public static List<Complex> DiscreteFourierTransformation(Complex[] data)
        {
            FourierTransform2.DFT(data, Accord.Math.FourierTransform.Direction.Forward);

            return data.OfType<Complex>().ToList();
        }

        public static List<Complex> InverseDiscreteFourierTransformation(Complex[] data)
        {
            FourierTransform2.DFT(data, Accord.Math.FourierTransform.Direction.Backward);

            return data.OfType<Complex>().ToList();
        }



    }
}
