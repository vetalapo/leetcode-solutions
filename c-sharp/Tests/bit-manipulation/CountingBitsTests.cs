using NUnit.Framework;

using Problems;

public class CountingBitsTests
{
    [TestCase( 2, ExpectedResult = new int[] { 0, 1, 1 } )]
    [TestCase( 5, ExpectedResult = new int[] { 0, 1, 1, 2, 1, 2 } )]
    public int[] CountBitsTest( int n ) =>
        new CountingBits().CountBits( n );
}
