using System.Collections;

using NUnit.Framework;

using Problems;

namespace LinkedList;

public class DeleteTheMiddleNodeOfALinkedListTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode DeleteMiddleTest( ListNode head ) =>
        new DeleteTheMiddleNodeOfALinkedList().DeleteMiddle( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 3, 4, 7, 1, 2, 6] ) ).Returns(
                ListNode.Create( [1, 3, 4, 1, 2, 6] )
            );

            yield return new TestCaseData( ListNode.Create( [1, 2, 3, 4] ) ).Returns(
                ListNode.Create( [1, 2, 4] )
            );

            yield return new TestCaseData( ListNode.Create( [2, 1] ) ).Returns(
                ListNode.Create( [2] )
            );
            
            yield return new TestCaseData( ListNode.Create( [1] ) ).Returns(
                ListNode.Create( [] )
            );
        }
    }
}