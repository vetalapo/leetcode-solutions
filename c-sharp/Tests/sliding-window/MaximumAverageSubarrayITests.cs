using System;

using NUnit.Framework;

using Problems;

public class MaximumAverageSubarrayITests
{
    [TestCase( new int[] { 1, 12, -5, -6, 50, 3 }, 4, ExpectedResult = 12.75000 )]
    [TestCase( new int[] { 5 }, 1, ExpectedResult = 5.00000 )]
    [TestCase( new int[] { -1 }, 1, ExpectedResult = -1.00000 )]
    [TestCase( new int[] { 9, 7, 3, 5, 6, 2, 0, 8, 1, 9 }, 6, ExpectedResult = 5.33333 )]
    public double FindMaxAverageTest( int[] nums, int k ) =>
        Math.Round( new MaximumAverageSubarrayI().FindMaxAverage( nums, k ), 5 );
}
