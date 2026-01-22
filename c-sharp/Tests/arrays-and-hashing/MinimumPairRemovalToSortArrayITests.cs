using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumPairRemovalToSortArrayITests
{
    [TestCase( new int[] { 5, 2, 3, 1 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 2, 2 }, ExpectedResult = 0 )]
    public int MinimumPairRemovalTest( int[] nums ) =>
        new MinimumPairRemovalToSortArrayI().MinimumPairRemoval( nums );
}
