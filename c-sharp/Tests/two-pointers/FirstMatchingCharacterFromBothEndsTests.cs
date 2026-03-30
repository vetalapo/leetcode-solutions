using NUnit.Framework;

using Problems;

public class FirstMatchingCharacterFromBothEndsTests
{
    [TestCase( "abcacbd", ExpectedResult = 1 )]
    [TestCase( "abc", ExpectedResult = 1 )]
    [TestCase( "abcdab", ExpectedResult = -1 )]
    public int FirstMatchingIndexTest( string s ) =>
        new FirstMatchingCharacterFromBothEnds().FirstMatchingIndex( s );
}
