using System.Collections;

using NUnit.Framework;

using Problems;

public class RemoveDuplicatesFromSortedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode DeleteDuplicatesTest( ListNode head ) =>
        new RemoveDuplicatesFromSortedList().DeleteDuplicates( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 1, 2] ) )
                .Returns( ListNode.Create( [1, 2] ) );

            yield return new TestCaseData( ListNode.Create( [1, 1, 2, 3, 3] ) )
                .Returns( ListNode.Create( [1, 2, 3] ) );

            yield return new TestCaseData( ListNode.Create( [] ) )
                .Returns( ListNode.Create( [] ) );
        }
    }
}
