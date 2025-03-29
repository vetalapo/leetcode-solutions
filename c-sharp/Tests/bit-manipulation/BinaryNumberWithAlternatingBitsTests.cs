using NUnit.Framework;

using Problems;

public class BinaryNumberWithAlternatingBitsTests
{
    [TestCase( 5, ExpectedResult = true )]
    [TestCase( 7, ExpectedResult = false )]
    [TestCase( 11, ExpectedResult = false )]
    public bool HasAlternatingBitsTest( int n ) =>
        new BinaryNumberWithAlternatingBits().HasAlternatingBits( n );
}
