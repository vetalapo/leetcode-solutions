using NUnit.Framework;

using Problems;

public class CheckIfStringIsAPrefixOfArrayTests
{
    [TestCase( "iloveleetcode", new string[] { "i", "love", "leetcode", "apples" }, ExpectedResult = true )]
    [TestCase( "iloveleetcode", new string[] { "apples", "i", "love", "leetcode" }, ExpectedResult = false )]
    [TestCase( "a", new string[] { "aa", "aaaa", "banana" }, ExpectedResult = false )]
    [TestCase( "z", new string[] { "z" }, ExpectedResult = true )]
    [TestCase( "ccccccccc", new string[] { "c", "cc" }, ExpectedResult = false )]
    public bool IsPrefixStringTest( string s, string[] words ) =>
        new CheckIfStringIsAPrefixOfArray().IsPrefixString( s, words );
}
