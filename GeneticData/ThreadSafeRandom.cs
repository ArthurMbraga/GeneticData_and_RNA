using System;
using System.Linq;

namespace GeneticData
{
    public static class ThreadSafeRandom
    {
        private static readonly Random _global = new Random();

        [ThreadStatic]
        private static Random _local;

        public static Random InitializeRandom()
        {
            Random inst = _local;
            if (inst == null)
            {
                int seed;
                lock (_global) seed = _global.Next();
                _local = inst = new Random(seed);
            }
            return inst;
        }

        public static int Next()
        {
            Random inst = InitializeRandom();

            return inst.Next();
        }

        public static int Next(int minValue, int maxValue)
        {
            Random inst = InitializeRandom();

            return inst.Next(minValue, maxValue);
        }

        public static bool TorF => Next(0, 2) == 0;

        public static int[] RandomNumbers(int amount) => Enumerable.Range(0, amount).OrderBy(x => Next()).ToArray();

        public static double NextDouble()
        {
            Random inst = InitializeRandom();

            return inst.NextDouble();
        }
    }
}
