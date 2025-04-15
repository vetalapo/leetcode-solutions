using NUnit.Framework;

using Problems;

public class CountOddNumbersInAnIntervalRangeTests
{
    [TestCase( 3, 7, ExpectedResult = 3 )]
    [TestCase( 8, 10, ExpectedResult = 1 )]
    [TestCase( 14, 17, ExpectedResult = 2 )]
    public int CountOddsTest( int low, int high ) =>
        new CountOddNumbersInAnIntervalRange().CountOdds( low, high );
}
