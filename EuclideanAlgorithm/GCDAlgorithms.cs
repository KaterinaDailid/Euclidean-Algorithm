using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EuclideanAlgorithm
{
    public class GCDAlgorithms
    {
        public static int GCDByEuclidean(int a, int b)
        {
            
            a = Math.Abs(a);
            b = Math.Abs(b);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string Time = String.Format("Hours {0:00}; Minutes {1:00}; Seconds {2:00}; Milliseconds {3:00}; Ticks {4};",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds, ts.Ticks);
            Console.WriteLine("RunTime " + Time);

            return a;
        }

        public static int GCDByEuclidean(params int[] a)
        {

            int c = GCDByEuclidean(a[0], a[1]);

            for (int i = 2; i < a.Length; i++)
            {
                c = GCDByEuclidean(a[i], c);
            }

            return c;

        }

        public static int GCDByBinary(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == b)
                return a;

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            if ((a % 2) == 0) // a четное
            {
                if (b % 2 == 1) // b нечетное
                    return GCDByEuclidean(a / 2, b);
                else
                    return 2 * GCDByEuclidean(a / 2, b / 2);
            }

            if (a % 2 == 1 && b % 2 == 0)
                return GCDByEuclidean(a, b / 2);

            if (b > a)
                return GCDByEuclidean((b - a) / 2, a);

            else
                return GCDByEuclidean((a - b) / 2, b);


        }


        public static int GCDByBinary(params int[] a)
        {
           
            int gcd = GCDByBinary(a[0], a[1]);

            for (int i = 2; i < a.Length; i++)
            {
                gcd = GCDByEuclidean(a[i], gcd);
            }

            return gcd;
        }
        

        
    }
}