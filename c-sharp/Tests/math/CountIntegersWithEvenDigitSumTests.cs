using NUnit.Framework;

using Problems;

public class CountIntegersWithEvenDigitSumTests
{
    [TestCase( 4, ExpectedResult = 2 )]
    [TestCase( 30, ExpectedResult = 14 )]
    [TestCase( 38, ExpectedResult = 18 )]
    [TestCase( 63, ExpectedResult = 31 )]
    public int CountEvenTest( int num ) =>
        new CountIntegersWithEvenDigitSum().CountEven( num );
}
