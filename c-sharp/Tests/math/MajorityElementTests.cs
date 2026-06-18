using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MajorityElementTests
{
    [TestCase( new int[] { 3, 2, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 2, 2, 1, 1, 1, 2, 2 }, ExpectedResult = 2 )]
    public int MajorityElementTest( int[] nums ) =>
        new MajorityElementSolution().MajorityElement( nums );
}