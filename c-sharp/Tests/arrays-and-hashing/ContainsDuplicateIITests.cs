using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ContainsDuplicateIITests
{
    [TestCase( new int[] { 1, 2, 3, 1 }, 3, ExpectedResult = true )]
    [TestCase( new int[] { 1, 0, 1, 1 }, 1, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 3, 1, 2, 3 }, 2, ExpectedResult = false )]
    public bool ContainsNearbyDuplicateTest( int[] nums, int k ) =>
        new ContainsDuplicateII().ContainsNearbyDuplicate( nums, k );
}
