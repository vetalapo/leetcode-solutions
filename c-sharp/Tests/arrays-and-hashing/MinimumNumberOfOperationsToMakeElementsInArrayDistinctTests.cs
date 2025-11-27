using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumNumberOfOperationsToMakeElementsInArrayDistinctTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 2, 3, 3, 5, 7 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 4, 5, 6, 4, 4 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 6, 7, 8, 9 }, ExpectedResult = 0 )]
    public int MinimumOperationsTest( int[] nums ) =>
        new MinimumNumberOfOperationsToMakeElementsInArrayDistinct().MinimumOperations( nums );
}
