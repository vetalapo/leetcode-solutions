using NUnit.Framework;

using Problems;

public class CountCommonWordsWithOneOccurrenceTests
{
    [TestCase( new string[] { "leetcode", "is", "amazing", "as", "is" }, new string[] { "amazing", "leetcode", "is" }, ExpectedResult = 2 )]
    [TestCase( new string[] { "b", "bb", "bbb" }, new string[] { "a", "aa", "aaa" }, ExpectedResult = 0 )]
    [TestCase( new string[] { "a", "ab" }, new string[] { "a", "a", "a", "ab" }, ExpectedResult = 1 )]
    public int CountWordsTest( string[] words1, string[] words2 ) =>
        new CountCommonWordsWithOneOccurrence().CountWords( words1, words2 );
}
