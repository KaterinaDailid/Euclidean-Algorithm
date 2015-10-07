using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuclideanAlgorithm;

namespace ConsoleForLogic
{
    class Program
    {
        static void Main(string[] args)
        {


             int[] d = null;


         
            System.Console.WriteLine(GCDAlgorithms.GCDByEuclidean(d));
            System.Console.WriteLine(GCDAlgorithms.GCDByBinary(1071, 462));
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
