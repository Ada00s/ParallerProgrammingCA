using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallerProgrammingCA
{
    public class PrimeNumbers
    {
        private ConcurrentBag<long> paralelList { get; set; }
        public static List<long> GetPrimesSequentially(long min, long max, out TimeSpan elapsed)
        {
            var ticks = new Stopwatch();
            ticks.Start();
            var results = new List<long>();
            for (long i = min; i <= max; i++)
            {
                if (CheckIfPrime(i))
                {
                    results.Add(i);
                }
            }
            ticks.Stop();
            elapsed = ticks.Elapsed;
            return results;
           
        }

        public ResultObj GetPrimesParallely(long min, long max)
        {
            var ticks = new Stopwatch();
            ticks.Start();
            paralelList = new ConcurrentBag<long>();
            Parallel.For(0, max, i =>
            {
                CheckIfPrime(i);
            });

            ticks.Stop();
            var elapsed = ticks.Elapsed;
            return new ResultObj(paralelList, elapsed) ;
        }

        private static bool CheckIfPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<long, long> ChunkRangeBy(long min, long max, int times)
        {
            var result = new Dictionary<long, long>();
            for(int i = 0; i <times; i++)
            {
                result.Add(min + ((max-min) / times) * i, min+((max-min)/times)*(i+1));
            }
            return result;
        }
    }
    public class ResultObj
    {
        public ConcurrentBag<long> list { get; set; }
        public TimeSpan elapsed { get; set; }

        public ResultObj(ConcurrentBag<long> ilist, TimeSpan ielapsed)
        {
            list = ilist;
            elapsed = ielapsed;
        }
    }
}
