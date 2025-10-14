using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class AdjacentIncreasingSubarraysDetectionITests
{
    [TestCase( new int[] { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 }, 3, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 }, 5, ExpectedResult = false )]
    [TestCase( new int[] { -15, 19 }, 1, ExpectedResult = true )]
    [TestCase( new int[] { -15, 3, 16, 0 }, 2, ExpectedResult = false )]
    public bool HasIncreasingSubarraysTest( IList<int> nums, int k ) =>
        new AdjacentIncreasingSubarraysDetectionI().HasIncreasingSubarrays( nums, k );
}
