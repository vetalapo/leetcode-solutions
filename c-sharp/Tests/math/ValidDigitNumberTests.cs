using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ValidDigitNumberTests
{
    [TestCase( 101, 0, ExpectedResult = true )]
    [TestCase( 232, 2, ExpectedResult = false )]
    [TestCase( 5, 1, ExpectedResult = false )]
    public bool ValidDigitTest( int n, int x ) =>
        new ValidDigitNumber().ValidDigit( n, x );
}