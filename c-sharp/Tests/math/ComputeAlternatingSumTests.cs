using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ComputeAlternatingSumTests
{
    [TestCase( new int[] { 1, 3, 5, 7 }, ExpectedResult = -4 )]
    [TestCase( new int[] { 100 }, ExpectedResult = 100 )]
    public int AlternatingSumTest( int[] nums ) =>
        new ComputeAlternatingSum().AlternatingSum( nums );
}
