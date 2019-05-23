using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    static class Utils
    {
        private static Stopwatch sw = new Stopwatch();


        public static TimeSpan TimingMethod(Delegate method)
        {
            sw = Stopwatch.StartNew();
            method.DynamicInvoke();
            sw.Stop();

            TimeSpan time = sw.Elapsed;
            sw.Reset();
            return time;
        }

        public static TimeSpan TimingMethod(Delegate method, params object[] parameters)
        {
            sw = Stopwatch.StartNew();
            method.DynamicInvoke(parameters);
            sw.Stop();

            TimeSpan time = sw.Elapsed;
            sw.Reset();
            return time;
        }

        public static void PrintTimingMethod(string identifier, Func<bool> method)
        {
            PrintResult(identifier, TimingMethod(method));
        }

        public static void PrintTimingMethod(string identifier, Action method)
        {
            PrintResult(identifier, TimingMethod(method));
        }

        private static void PrintResult(string identifier, TimeSpan time)
        {
            Console.WriteLine("----({0})----\nelapsed={1}", identifier, time);
        }
    }
}
