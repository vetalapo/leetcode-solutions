using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MakeArrayZeroBySubtractingEqualAmountsTests
{
    [TestCase( new int[] { 1, 5, 0, 3, 5 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 0 }, ExpectedResult = 0 )]
    public int MinimumOperationsTest( int[] nums ) =>
        new MakeArrayZeroBySubtractingEqualAmounts().MinimumOperations( nums );
}
