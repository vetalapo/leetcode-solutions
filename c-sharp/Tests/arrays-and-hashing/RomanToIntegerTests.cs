using NUnit.Framework;

using Problems;

public class RomanToIntegerTests
{
    [TestCase( "III", ExpectedResult = 3 )]
    [TestCase( "LVIII", ExpectedResult = 58 )]
    [TestCase( "MCMXCIV", ExpectedResult = 1994 )]
    public int RomanToIntTest( string s ) =>
        new RomanToInteger().RomanToInt( s );
}
