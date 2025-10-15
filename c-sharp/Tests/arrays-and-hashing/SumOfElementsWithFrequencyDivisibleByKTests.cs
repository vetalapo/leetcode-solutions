using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SumOfElementsWithFrequencyDivisibleByKTests
{
    [TestCase( new int[] { 1, 2, 2, 3, 3, 3, 3, 4 }, 2, ExpectedResult = 16 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = 0 )]
    [TestCase( new int[] { 4, 4, 4, 1, 2, 3 }, 3, ExpectedResult = 12 )]
    public int SumDivisibleByKTest( int[] nums, int k ) =>
        new SumOfElementsWithFrequencyDivisibleByK().SumDivisibleByK( nums, k );
}
