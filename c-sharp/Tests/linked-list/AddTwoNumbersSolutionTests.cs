using System.Collections;

using NUnit.Framework;

using Problems;

namespace LinkedList;

public class AddTwoNumbersSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public ListNode AddTwoNumbersTest( ListNode l1, ListNode l2 ) =>
        new AddTwoNumbersSolution().AddTwoNumbers( l1, l2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [2, 4, 3] ), ListNode.Create( [5, 6, 4] ) )
                .Returns( ListNode.Create( [7, 0, 8] ) );

            yield return new TestCaseData( ListNode.Create( [0] ), ListNode.Create( [0] ) )
                .Returns( ListNode.Create( [0] ) );

            yield return new TestCaseData( ListNode.Create( [9, 9, 9, 9, 9, 9, 9] ), ListNode.Create( [9, 9, 9, 9] ) )
                .Returns( ListNode.Create( [8, 9, 9, 9, 0, 0, 0, 1] ) );
        }
    }
}
