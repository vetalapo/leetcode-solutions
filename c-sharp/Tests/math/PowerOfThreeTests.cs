using NUnit.Framework;

using Problems;

public class PowerOfThreeTests
{
    [TestCase( 27, ExpectedResult = true )]
    [TestCase( 0, ExpectedResult = false )]
    [TestCase( -1, ExpectedResult = false )]
    [TestCase( 45, ExpectedResult = false )]
    [TestCase( 1, ExpectedResult = true )]
    [TestCase( 243, ExpectedResult = true )]
    public bool IsPowerOfThreeTest( int n ) =>
        new PowerOfThree().IsPowerOfThree( n );
}
