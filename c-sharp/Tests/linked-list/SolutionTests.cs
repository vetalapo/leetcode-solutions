using System.Collections;

using NUnit.Framework;

using Problems;

public class RemoveLinkedListElementsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode RemoveElementsTest( ListNode head, int val ) =>
        new RemoveLinkedListElements().RemoveElements( head, val );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 2, 6, 3, 4, 5, 6] ), 6 )
                .Returns( ListNode.Create( [1, 2, 3, 4, 5] ) );

            yield return new TestCaseData( ListNode.Create( [] ), 1 )
                .Returns( ListNode.Create( [] ) );

            yield return new TestCaseData( ListNode.Create( [7, 7, 7, 7] ), 7 )
                .Returns( ListNode.Create( [] ) );

            yield return new TestCaseData( ListNode.Create( [1, 2, 2, 1] ), 2 )
                .Returns( ListNode.Create( [1, 1] ) );
        }
    }
}
