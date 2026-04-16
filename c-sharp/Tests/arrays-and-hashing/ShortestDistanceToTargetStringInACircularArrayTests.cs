using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ShortestDistanceToTargetStringInACircularArrayTests
{
    [TestCase( new string[] { "hello","i","am","leetcode","hello" }, "hello", 1, ExpectedResult = 1 )]
    [TestCase( new string[] { "a","b","leetcode" }, "leetcode", 0, ExpectedResult = 1 )]
    [TestCase( new string[] { "i","eat","leetcode" }, "ate", 0, ExpectedResult = -1 )]
    public int ClosestTargetTest( string[] words, string target, int startIndex ) =>
        new ShortestDistanceToTargetStringInACircularArray().ClosestTarget( words, target, startIndex );
}
