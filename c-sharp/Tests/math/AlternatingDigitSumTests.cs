using NUnit.Framework;

using Problems;

public class AlternatingDigitSumTests
{
    [TestCase( 521, ExpectedResult = 4 )]
    [TestCase( 111, ExpectedResult = 1 )]
    [TestCase( 886996, ExpectedResult = 0 )]
    public int AlternateDigitSumTest( int n ) =>
        new AlternatingDigitSum().AlternateDigitSum( n );
}
