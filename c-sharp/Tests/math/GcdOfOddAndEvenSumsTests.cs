using NUnit.Framework;

using Problems;
public class GcdOfOddAndEvenSumsTests
{
    [TestCase( 4, ExpectedResult = 4 )]
    [TestCase( 5, ExpectedResult = 5 )]
    public int GcdOfOddEvenSumsTest( int n ) =>
        new GcdOfOddAndEvenSums().GcdOfOddEvenSums( n );
}
