using NUnit.Framework;

using Problems;

namespace Greedy;

public class AppleRedistributionIntoBoxesTests
{
    [TestCase( new int[] { 1, 3, 2 }, new int[] { 4, 3, 1, 5, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 5, 5, 5 }, new int[] { 2, 4, 2, 7 }, ExpectedResult = 4 )]
    public int MinimumBoxesTest( int[] apple, int[] capacity ) =>
        new AppleRedistributionIntoBoxes().MinimumBoxes( apple, capacity );
}
