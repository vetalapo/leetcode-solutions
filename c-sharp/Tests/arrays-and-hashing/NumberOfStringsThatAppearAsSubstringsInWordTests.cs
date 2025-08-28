using NUnit.Framework;

using Problems;

public class NumberOfStringsThatAppearAsSubstringsInWordTests
{
    [TestCase( [new string[] { "a", "abc", "bc", "d" }, "abc"], ExpectedResult = 3 )]
    [TestCase( [new string[] { "a", "b", "c" }, "aaaaabbbbb"], ExpectedResult = 2 )]
    [TestCase( [new string[] { "a", "a", "a" }, "ab"], ExpectedResult = 3 )]
    [TestCase( [new string[] { "hvzoo", "r", "hyjcrgzr", "yvqahvz", "org", "yvqahvz", "org", "oor", "gxe", "zo", "ahvzoo", "ahvzo", "r", "o", "caviikty", "pkxlcaams" }, "tyvqahvzoorg"], ExpectedResult = 12 )]
    public int NumOfStringsTest( string[] patterns, string word ) =>
        new NumberOfStringsThatAppearAsSubstringsInWord().NumOfStrings( patterns, word );
}
