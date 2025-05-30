using NUnit.Framework;

using Problems;

public class DuplicateZerosSolutionTests
{
    [TestCase( new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, ExpectedResult = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 } )]
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3 } )]
    [TestCase( new int[] { 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0, 0, 0, 0, 0 } )]
    [TestCase( new int[] { 1, 5, 2, 0, 6, 8, 0, 6, 0 }, ExpectedResult = new int[] { 1, 5, 2, 0, 0, 6, 8, 0, 0 } )]
    public int[] DuplicateZerosTest( int[] arr )
    {
        new DuplicateZerosSolution().DuplicateZeros( arr );

        return arr;
    }
}
