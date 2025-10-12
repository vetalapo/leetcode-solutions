using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class NRepeatedElementInSize2nArrayTests
{
    [TestCase( new int[] { 1, 2, 3, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 2, 1, 2, 5, 3, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }, ExpectedResult = 5 )]
    public int RepeatedNTimesTest( int[] nums ) =>
        new NRepeatedElementInSize2nArray().RepeatedNTimes( nums );
}
