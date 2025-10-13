using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindResultantArrayAfterRemovingAnagramsTests
{
    [TestCase( [new string[] { "abba", "baba", "bbaa", "cd", "cd" }], ExpectedResult = new string[] { "abba", "cd" } )]
    [TestCase( [new string[] { "a", "b", "c", "d", "e" }], ExpectedResult = new string[] { "a", "b", "c", "d", "e" } )]
    [TestCase( [new string[] { "a", "b", "a" }], ExpectedResult = new string[] { "a", "b", "a" } )]
    public IList<string> RemoveAnagramsTest( string[] words ) =>
        new FindResultantArrayAfterRemovingAnagrams().RemoveAnagrams( words );
}
