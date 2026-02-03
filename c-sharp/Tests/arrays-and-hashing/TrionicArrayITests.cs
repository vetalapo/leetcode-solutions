using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class TrionicArrayITests
{
    [TestCase( new int[] { 1, 3, 5, 4, 2, 6 }, ExpectedResult = true )]
    [TestCase( new int[] { 2, 1, 3 }, ExpectedResult = false )]
    public bool IsTrionicTest( int[] nums ) =>
        new TrionicArrayI().IsTrionic( nums );
}
