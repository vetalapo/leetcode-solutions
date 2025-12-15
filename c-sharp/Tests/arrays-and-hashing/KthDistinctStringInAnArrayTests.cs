using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class KthDistinctStringInAnArrayTests
{
    [TestCase( new string[] { "d", "b", "c", "b", "c", "a" }, 2, ExpectedResult = "a" )]
    [TestCase( new string[] { "aaa", "aa", "a" }, 1, ExpectedResult = "aaa" )]
    [TestCase( new string[] { "a", "b", "a" }, 3, ExpectedResult = "" )]
    public string KthDistinctTest( string[] arr, int k ) =>
        new KthDistinctStringInAnArray().KthDistinct( arr, k );
}
