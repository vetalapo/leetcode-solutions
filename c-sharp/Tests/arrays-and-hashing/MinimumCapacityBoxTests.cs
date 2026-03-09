using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumCapacityBoxTests
{
    [TestCase( new int[] { 1, 5, 3, 7 }, 3, ExpectedResult = 2 )]
    [TestCase( new int[] { 3, 5, 4, 3 }, 2, ExpectedResult = 0 )]
    [TestCase( new int[] { 4 }, 5, ExpectedResult = -1 )]
    public int MinimumIndexTest( int[] capacity, int itemSize ) =>
        new MinimumCapacityBox().MinimumIndex( capacity, itemSize );
}
