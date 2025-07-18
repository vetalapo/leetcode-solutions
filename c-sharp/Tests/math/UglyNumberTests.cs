using NUnit.Framework;

using Problems;

public class UglyNumberTests
{
    [TestCase( 6, ExpectedResult = true )]
    [TestCase( 1, ExpectedResult = true )]
    [TestCase( 14, ExpectedResult = false )]
    [TestCase( -2147483648, ExpectedResult = false )]
    public bool IsUglyTest( int n ) =>
        new UglyNumber().IsUgly( n );
}
