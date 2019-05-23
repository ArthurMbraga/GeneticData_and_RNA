using System;

namespace GeneticData
{
    public static class Binomial
    {
        /// <summary>
        /// nCr(n,k) * success^k * (1-success)^(n-k)
        /// </summary>
        public static double CalculateChance(int n, int k, float success)
        {
            double v1 = nCr(n, k);
            double v2 = Math.Pow(success, k);
            double v3 = Math.Pow(1 - success, n - k);

            double c1 = v1 * v2;
            double c2 = c1 * v3;

            //double temp = nCr(n, k) * Math.Pow(success, k) * Math.Pow(1 - success, n - k);
            double result = Math.Round(c2, 4);

            if (double.IsNaN(result))
                result = 0;

            return result;
        }

        /// <summary>
        /// Combination n!/((n - p)! p!)
        /// </summary>
        public static double nCr(int n, int p)
        {
            if (p == 8)
                p = 8;

            int a = n - p;
            double division;

            if (a > p)
            {
                division = Factorial(n, a);
                division = Math.Round(division / Factorial(p), 4);
            }
            else
            {
                division = Factorial(n, p);
                division /= Math.Round(division / Factorial(a), 4);
            }

            return division;
        }

        /// <summary>
        /// n!
        /// </summary>
        public static double Factorial(int n)
        {
            long value = 1;

            for (int i = 1; i <= n; i++)
                value *= i;

            if (value == 0)
                value = long.MaxValue;

            return value;
        }

        /// <summary>
        /// n!/a!
        /// </summary>
        public static double Factorial(int n, int a)
        {
            long value = 1;

            for (int x = (a + 1); x <= n; x++)
                value *= x;

            if (value <= 0)
                value = long.MaxValue;

            return value;
        }
    }
}
