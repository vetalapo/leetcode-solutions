using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class HowManyNumbersAreSmallerThanTheCurrentNumberTests
{
    [TestCase( new int[] { 8, 1, 2, 2, 3 }, ExpectedResult = new int[] { 4, 0, 1, 1, 3 } )]
    [TestCase( new int[] { 6, 5, 4, 8 }, ExpectedResult = new int[] { 2, 1, 0, 3 } )]
    [TestCase( new int[] { 7, 7, 7, 7 }, ExpectedResult = new int[] { 0, 0, 0, 0 } )]
    public int[] SmallerNumbersThanCurrentTest( int[] nums ) =>
        new HowManyNumbersAreSmallerThanTheCurrentNumber().SmallerNumbersThanCurrent( nums );
}
