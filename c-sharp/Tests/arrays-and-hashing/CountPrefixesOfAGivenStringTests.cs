using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountPrefixesOfAGivenStringTests
{
    [TestCase( new string[] { "a", "b", "c", "ab", "bc", "abc" }, "abc", ExpectedResult = 3 )]
    [TestCase( new string[] { "a", "a" }, "aa", ExpectedResult = 2 )]
    public int CountPrefixesTest( string[] words, string s ) =>
        new CountPrefixesOfAGivenString().CountPrefixes( words, s );
}
