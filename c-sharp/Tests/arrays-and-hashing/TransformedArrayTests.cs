using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class TransformedArrayTests
{
    [TestCase( new int[] { 3, -2, 1, 1 }, ExpectedResult = new int[] { 1, 1, 1, 3 } )]
    [TestCase( new int[] { -1, 4, -1 }, ExpectedResult = new int[] { -1, -1, 4 } )]
    [TestCase( new int[] { -10, -10, -4 }, ExpectedResult = new int[] { -4, -10, -10 } )]
    [TestCase( new int[] { -10, -10 }, ExpectedResult = new int[] { -10, -10 } )]
    public int[] ConstructTransformedArrayTest( int[] nums ) =>
        new TransformedArray().ConstructTransformedArray( nums );
}
