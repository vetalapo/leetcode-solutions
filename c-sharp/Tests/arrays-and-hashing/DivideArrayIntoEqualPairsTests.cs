using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DivideArrayIntoEqualPairsTests
{
    [TestCase( new int[] { 3, 2, 3, 2, 2, 2 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = false )]
    [TestCase( new int[] { 6, 12, 11, 20, 17, 4 }, ExpectedResult = false )]
    public bool DivideArrayTest( int[] nums ) =>
        new DivideArrayIntoEqualPairs().DivideArray( nums );
}
