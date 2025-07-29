using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class SumOfValuesAtIndicesWithKSetBitsTests
{
    [TestCase( new int[] { 5, 10, 1, 5, 2 }, 1, ExpectedResult = 13 )]
    [TestCase( new int[] { 4, 3, 2, 1 }, 2, ExpectedResult = 1 )]
    [TestCase( new int[] { 1 }, 0, ExpectedResult = 1 )]
    public int SumIndicesWithKSetBitsTest( IList<int> nums, int k ) =>
        new SumOfValuesAtIndicesWithKSetBits().SumIndicesWithKSetBits( nums, k );
}
