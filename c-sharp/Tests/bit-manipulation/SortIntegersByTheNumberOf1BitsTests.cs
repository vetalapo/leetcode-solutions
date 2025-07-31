using NUnit.Framework;

using Problems;

public class SortIntegersByTheNumberOf1BitsTests
{
    [TestCase( new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, ExpectedResult = new int[] { 0, 1, 2, 4, 8, 3, 5, 6, 7 } )]
    [TestCase( new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 }, ExpectedResult = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 } )]
    public int[] SortByBitsTest( int[] arr ) =>
        new SortIntegersByTheNumberOf1Bits().SortByBits( arr );
}
