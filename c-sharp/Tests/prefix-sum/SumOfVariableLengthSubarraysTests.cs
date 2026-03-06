using NUnit.Framework;

using Problems;

namespace PrefixSum;

public class SumOfVariableLengthSubarraysTests
{
    [TestCase( new int[] { 2, 3, 1 }, ExpectedResult = 11 )]
    [TestCase( new int[] { 3, 1, 1, 2 }, ExpectedResult = 13 )]
    public int SubarraySumTest( int[] nums ) =>
        new SumOfVariableLengthSubarrays().SubarraySum( nums );
}
