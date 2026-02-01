using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DivideAnArrayIntoSubarraysWithMinimumCostITests
{
    [TestCase( new int[] { 1, 2, 3, 12 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 5, 4, 3 }, ExpectedResult = 12 )]
    [TestCase( new int[] { 10, 3, 1, 1 }, ExpectedResult = 12 )]
    [TestCase( new int[] { 1, 26, 22, 2, 6, 32, 8, 36, 7, 47 }, ExpectedResult = 9 )]
    public int MinimumCostTest( int[] nums ) =>
        new DivideAnArrayIntoSubarraysWithMinimumCostI().MinimumCost( nums );
}
