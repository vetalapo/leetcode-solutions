using System.Linq;

using NUnit.Framework;

using Problems;

public class FindNUniqueIntegersSumUpToZeroTests
{
    private static readonly int[] cases = [5, 3, 1, 500, 1000];

    [TestCaseSource( nameof( cases ) )]
    public void SumZeroTest( int n )
    {
        int[] result = new FindNUniqueIntegersSumUpToZero().SumZero( n );

        Assert.AreEqual( result.Sum(), 0 );
    }
}
