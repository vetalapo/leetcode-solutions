using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MinimumMovesToEqualArrayElementsIIITests
{
    [TestCase( new int[] { 2, 1, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 4, 4, 5 }, ExpectedResult = 2 )]
    public int MinMovesTest( int[] nums ) =>
        new MinimumMovesToEqualArrayElementsIII().MinMoves( nums );
}
