using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountDominantIndicesTests
{
    [TestCase( new int[] { 5, 4, 3 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 4, 1, 2 }, ExpectedResult = 1 )]
    public int DominantIndicesTest( int[] nums ) =>
        new CountDominantIndices().DominantIndices( nums );
}
