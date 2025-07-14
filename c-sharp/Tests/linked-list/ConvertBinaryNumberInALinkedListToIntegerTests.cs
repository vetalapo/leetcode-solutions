using System.Collections;

using NUnit.Framework;

using Problems;

public class ConvertBinaryNumberInALinkedListToIntegerTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int GetDecimalValueTest( ListNode head ) =>
        new ConvertBinaryNumberInALinkedListToInteger().GetDecimalValue( head );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( ListNode.Create( [1, 0, 1] ) ).Returns( 5 );

            yield return new TestCaseData( ListNode.Create( [0] ) ).Returns( 0 );

            yield return new TestCaseData( ListNode.Create( [1, 0, 0, 0] ) ).Returns( 8 );
        }
    }
}
