using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DeleteColumnsToMakeSortedTests
{
    [TestCase( [new string[] { "cba", "daf", "ghi" }], ExpectedResult = 1 )]
    [TestCase( [new string[] { "a", "b" }], ExpectedResult = 0 )]
    [TestCase( [new string[] { "zyx", "wvu", "tsr" }], ExpectedResult = 3 )]
    public int MinDeletionSizeTest( string[] strs ) =>
        new DeleteColumnsToMakeSorted().MinDeletionSize( strs );
}
