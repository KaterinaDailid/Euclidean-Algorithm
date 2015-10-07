using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclideanAlgorithm;
using NUnit.Framework;


namespace TestsForAlgorithm
{
    [TestFixture]
    public class GCDAlgorithmTests
    {
        [TestCase(1071, 462, Result = 21)]
        [TestCase(-1071, -462, Result = 21)]
        [TestCase(-1071, 462, Result = 21)]
        [TestCase(-1071, 0, Result = 1071)]
        [TestCase(0, 462, Result = 462)]
        public int CountGCDByEuclideanAlgorithmForTwoNumbers(int a, int b)
        {

            int actGCD = GCDAlgorithms.GCDByEuclidean(a, b);

            return actGCD;
        }

        [TestCase(1071, 462, Result = 21)]
        [TestCase(-1071, -462, Result = 21)]
        [TestCase(-1071, 462, Result = 21)]
        [TestCase(-1071, 0, Result = 1071)]
        [TestCase(0, 462, Result = 462)]
        public int CountGCDByBinaryAlgorithmForTwoNumbers(int a, int b)
        {

            int actGCD = GCDAlgorithms.GCDByBinary(a, b);

            return actGCD;
        }

        [TestCase(252, 441, 1080, Result = 9)]
        [TestCase(-252, -441, 1080, Result = 9)]
        [TestCase(252, -441, 1080, Result = 9)]
        [TestCase(252, -441, -1080, Result = 9)]
        [TestCase(252, 441, -1080, Result = 9)]
        [TestCase(-252, 441, 1080, Result = 9)]
        [TestCase(0, 441, 1080, Result = 9)]
        [TestCase(252, 0, 1080, Result = 36)]
        [TestCase(252, 441, 0, Result = 63)]
        [TestCase(0, -441, 1080, Result = 9)]
        [TestCase(252, 0, -1080, Result = 36)]
        [TestCase(-252, 441, 0, Result = 63)]
        [TestCase(0, 441, 1080, Result = 9)]
        [TestCase(252, 0, 1080, Result = 36)]
        [TestCase(252, 441, 0, 1080, 36, 72, Result = 9)]
        public int CountGCDByEuclideanAlgorithmForThreeAndMoreNumbers(params int[] a)
        {

            int actGCD = GCDAlgorithms.GCDByEuclidean(a);
             
            return actGCD;
        }


        [TestCase(252, 441, 1080, Result = 9)]
        [TestCase(-252, -441, 1080, Result = 9)]
        [TestCase(252, -441, 1080, Result = 9)]
        [TestCase(252, -441, -1080, Result = 9)]
        [TestCase(252, 441, -1080, Result = 9)]
        [TestCase(-252, 441, 1080, Result = 9)]
        [TestCase(0, 441, 1080, Result = 9)]
        [TestCase(252, 0, 1080, Result = 36)]
        [TestCase(252, 441, 0, Result = 63)]
        [TestCase(0, -441, 1080, Result = 9)]
        [TestCase(252, 0, -1080, Result = 36)]
        [TestCase(-252, 441, 0, Result = 63)]
        [TestCase(0, 441, 1080, Result = 9)]
        [TestCase(252, 0, 1080, Result = 36)]
        [TestCase(252, 441, 0, 1080, 36, 72, Result = 9)]
        public int CountGCDByBinaryAlgorithmForThreeAndMoreNumbers(params int[] a)
        {

            int actGCD = GCDAlgorithms.GCDByBinary(a);

            return actGCD;
        }


    }
        
        
    
}

