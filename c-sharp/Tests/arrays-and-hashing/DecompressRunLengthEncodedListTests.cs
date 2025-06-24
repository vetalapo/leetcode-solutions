using NUnit.Framework;

using Problems;

public class DecompressRunLengthEncodedListTests
{
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 2, 4, 4, 4 } )]
    [TestCase( new int[] { 1, 1, 2, 3 }, ExpectedResult = new int[] { 1, 3, 3 } )]
    public int[] DecompressRLElistTest( int[] nums ) =>
        new DecompressRunLengthEncodedList().DecompressRLElist( nums );
}
