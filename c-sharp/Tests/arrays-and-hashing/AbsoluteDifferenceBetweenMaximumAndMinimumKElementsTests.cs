using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class AbsoluteDifferenceBetweenMaximumAndMinimumKElementsTests
{
    [TestCase( new int[] { 5, 2, 2, 4 }, 2, ExpectedResult = 5 )]
    [TestCase( new int[] { 100 }, 1, ExpectedResult = 0 )]
    public int AbsDifferenceTest( int[] nums, int k ) =>
        new AbsoluteDifferenceBetweenMaximumAndMinimumKElements().AbsDifference( nums, k );
}
