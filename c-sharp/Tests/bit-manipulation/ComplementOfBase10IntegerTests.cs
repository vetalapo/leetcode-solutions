using NUnit.Framework;

using Problems;

public class ComplementOfBase10IntegerTests
{
    [TestCase( 0, ExpectedResult = 1 )]
    [TestCase( 5, ExpectedResult = 2 )]
    [TestCase( 7, ExpectedResult = 0 )]
    [TestCase( 10, ExpectedResult = 5 )]
    public int BitwiseComplementTest( int n ) =>
        new ComplementOfBase10Integer().BitwiseComplement( n );
}
