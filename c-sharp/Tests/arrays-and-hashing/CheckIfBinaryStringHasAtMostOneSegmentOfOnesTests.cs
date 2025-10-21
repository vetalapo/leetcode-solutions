using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckIfBinaryStringHasAtMostOneSegmentOfOnesTests
{
    [TestCase( "1001", ExpectedResult = false )]
    [TestCase( "110", ExpectedResult = true )]
    public bool CheckOnesSegmentTest( string s ) =>
        new CheckIfBinaryStringHasAtMostOneSegmentOfOnes().CheckOnesSegment( s );
}
