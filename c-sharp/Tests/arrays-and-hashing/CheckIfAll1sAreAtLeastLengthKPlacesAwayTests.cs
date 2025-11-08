using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckIfAll1sAreAtLeastLengthKPlacesAwayTests
{
    [TestCase( new int[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2, ExpectedResult = true )]
    [TestCase( new int[] { 1, 0, 0, 1, 0, 1 }, 2, ExpectedResult = false )]
    public bool KLengthApartTest( int[] nums, int k ) =>
        new CheckIfAll1sAreAtLeastLengthKPlacesAway().KLengthApart( nums, k );
}
