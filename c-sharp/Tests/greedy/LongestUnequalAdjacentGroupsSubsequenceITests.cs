using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class LongestUnequalAdjacentGroupsSubsequenceITests
{
    [TestCase( new string[] { "c" }, new int[] { 0 }, ExpectedResult = new string[] { "c" } )]
    [TestCase( new string[] { "d" }, new int[] { 1 }, ExpectedResult = new string[] { "d" } )]
    [TestCase( new string[] { "e", "a", "b" }, new int[] { 0, 0, 1 }, ExpectedResult = new string[] { "e", "b" } )]
    [TestCase( new string[] { "a", "b", "c", "d" }, new int[] { 1, 0, 1, 1 }, ExpectedResult = new string[] { "a", "b", "c" } )]
    [TestCase( new string[] { "d", "a", "v", "b" }, new int[] { 1, 0, 0, 1 }, ExpectedResult = new string[] { "d", "a", "b" } )]
    public IList<string> GetLongestSubsequenceTest( string[] words, int[] groups ) =>
        new LongestUnequalAdjacentGroupsSubsequenceI().GetLongestSubsequence( words, groups );
}
