using NUnit.Framework;

using Problems;

public class SearchInsertPositionTests
{
    [TestCase( new int[] { 1, 3, 5, 6 }, 5, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 3, 5, 6 }, 2, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 3, 5, 6 }, 7, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 3 }, 2, ExpectedResult = 1 )]
    public int SearchInsertTest( int[] nums, int target ) =>
        new SearchInsertPosition().SearchInsert( nums, target );
}
