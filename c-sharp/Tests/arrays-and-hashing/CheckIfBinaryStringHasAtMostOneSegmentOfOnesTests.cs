using NUnit.Framework;

using Problems;

public class CheckIfBinaryStringHasAtMostOneSegmentOfOnesTests
{
    [TestCase( "1001", ExpectedResult = false )]
    [TestCase( "110", ExpectedResult = true )]
    public bool CheckOnesSegmentTest( string s ) =>
        new CheckIfBinaryStringHasAtMostOneSegmentOfOnes().CheckOnesSegment( s );
}
