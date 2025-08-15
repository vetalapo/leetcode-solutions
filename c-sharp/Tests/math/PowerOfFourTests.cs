using NUnit.Framework;

using Problems;

public class PowerOfFourTests
{
    [TestCase( 16, ExpectedResult = true )]
    [TestCase( 5, ExpectedResult = false )]
    [TestCase( 1, ExpectedResult = true )]
    [TestCase( -128, ExpectedResult = false )]
    [TestCase( 1024, ExpectedResult = true )]
    [TestCase( 1048576, ExpectedResult = true )]
    public bool IsPowerOfFourTest( int n ) =>
        new PowerOfFour().IsPowerOfFour( n );
}
