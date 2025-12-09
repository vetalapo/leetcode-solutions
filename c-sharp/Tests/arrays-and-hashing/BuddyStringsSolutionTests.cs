using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class BuddyStringsSolutionTests
{
    [TestCase( "ab", "ba", ExpectedResult = true )]
    [TestCase( "ab", "ab", ExpectedResult = false )]
    [TestCase( "aa", "aa", ExpectedResult = true )]
    [TestCase( "abcaa", "abcbb", ExpectedResult = false )]
    [TestCase( "ab", "babbb", ExpectedResult = false )]
    public bool BuddyStringsTest( string s, string goal ) =>
        new BuddyStringsSolution().BuddyStrings( s, goal );
}
