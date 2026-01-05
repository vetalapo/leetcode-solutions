using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DeleteCharactersToMakeFancyStringTests
{
    [TestCase( "leeetcode", ExpectedResult = "leetcode" )]
    [TestCase( "aaabaaaa", ExpectedResult = "aabaa" )]
    [TestCase( "aab", ExpectedResult = "aab" )]
    [TestCase( "a", ExpectedResult = "a" )]
    public string MakeFancyStringTest( string s ) =>
        new DeleteCharactersToMakeFancyString().MakeFancyString( s );
}
