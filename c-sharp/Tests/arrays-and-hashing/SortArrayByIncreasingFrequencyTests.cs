using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SortArrayByIncreasingFrequencyTests
{
    [TestCase( new int[] { 1, 1, 2, 2, 2, 3 }, ExpectedResult = new int[] { 3, 1, 1, 2, 2, 2 } )]
    [TestCase( new int[] { 2, 3, 1, 3, 2 }, ExpectedResult = new int[] { 1, 3, 3, 2, 2 } )]
    [TestCase( new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, ExpectedResult = new int[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 } )]
    public int[] FrequencySortTest( int[] nums ) =>
        new SortArrayByIncreasingFrequency().FrequencySort( nums );
}
