using NUnit.Framework;

using Problems;
public class NumberOfEvenAndOddBitsTests
{
    [TestCase( 50, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( 2, ExpectedResult = new int[] { 0, 1 } )]
    public int[] EvenOddBitTest( int n ) =>
        new NumberOfEvenAndOddBits().EvenOddBit( n );
}
