using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class KeepMultiplyingFoundValuesByTwoTests
{
    [TestCase( new int[] { 5, 3, 6, 1, 12 }, 3, ExpectedResult = 24 )]
    [TestCase( new int[] { 2, 7, 9 }, 4, ExpectedResult = 4 )]
    [TestCase( new int[] { 161, 28, 640, 264, 81, 561, 320, 2, 61, 244, 183, 108, 773, 61, 976, 122, 988, 2, 370, 392, 488, 375, 349, 432, 713, 563 }, 61, ExpectedResult = 1952 )]
    public int FindFinalValueTest( int[] nums, int original ) =>
        new KeepMultiplyingFoundValuesByTwo().FindFinalValue( nums, original );
}