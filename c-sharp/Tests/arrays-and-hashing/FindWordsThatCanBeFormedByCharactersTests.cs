using NUnit.Framework;

using Problems;

public class FindWordsThatCanBeFormedByCharactersTests
{
    [TestCase( [new string[] { "cat", "bt", "hat", "tree" }, "atach"], ExpectedResult = 6 )]
    [TestCase( [new string[] { "hello", "world", "leetcode" }, "welldonehoneyr"], ExpectedResult = 10 )]
    public int CountCharactersTest( string[] words, string chars ) =>
        new FindWordsThatCanBeFormedByCharacters().CountCharacters( words, chars );
}
