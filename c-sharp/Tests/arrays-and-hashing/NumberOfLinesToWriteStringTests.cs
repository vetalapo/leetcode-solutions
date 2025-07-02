using NUnit.Framework;

using Problems;

public class NumberOfLinesToWriteStringTests
{
    [TestCase( new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "abcdefghijklmnopqrstuvwxyz", ExpectedResult = new int[] { 3, 60 } )]
    [TestCase( new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa", ExpectedResult = new int[] { 2, 4 } )]
    public int[] NumberOfLinesTest( int[] widths, string s ) =>
        new NumberOfLinesToWriteString().NumberOfLines( widths, s );
}
