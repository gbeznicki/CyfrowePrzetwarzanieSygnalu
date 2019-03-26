using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public static class Extensions
    {
        public static double NextGaussian(this Random random, double mu = 0, double sigma = 1)
        {
            double u1 = 1.0 - random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                   Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal = mu + sigma * randStdNormal; //random normal(mean,stdDev^2)
            return randNormal;
        }
    }
}
