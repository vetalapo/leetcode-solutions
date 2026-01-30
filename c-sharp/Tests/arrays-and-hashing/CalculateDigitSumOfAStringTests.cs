using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CalculateDigitSumOfAStringTests
{
    [TestCase( "11111222223", 3, ExpectedResult = "135" )]
    [TestCase( "00000000", 3, ExpectedResult = "000" )]
    [TestCase( "1234", 2, ExpectedResult = "37" )]
    public string DigitSumTest( string s, int k ) =>
        new CalculateDigitSumOfAString().DigitSum( s, k );
}
