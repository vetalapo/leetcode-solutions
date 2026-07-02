using NUnit.Framework;

using Problems;

namespace PrefixSum;

public class CountIndicesWithOppositeParityTests
{
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 2, 1, 1, 0 } )]
    [TestCase( new int[] { 1 }, ExpectedResult = new int[] { 0 } )]
    public int[] CountOppositeParityTest( int[] nums ) =>
        new CountIndicesWithOppositeParity().CountOppositeParity( nums );
}