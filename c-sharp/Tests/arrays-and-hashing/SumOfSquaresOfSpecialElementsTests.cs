using NUnit.Framework;

using Problems;

public class SumOfSquaresOfSpecialElementsTests
{
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = 21 )]
    [TestCase( new int[] { 2, 7, 1, 19, 18, 3 }, ExpectedResult = 63 )]
    public int SumOfSquaresTest( int[] nums ) =>
        new SumOfSquaresOfSpecialElements().SumOfSquares( nums );
}
