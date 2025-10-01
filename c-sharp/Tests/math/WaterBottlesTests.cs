using System.Collections;

using NUnit.Framework;

using Problems;

namespace Mathematics;

public class WaterBottlesTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int NumWaterBottlesTest( int numBottles, int numExchange ) =>
        new WaterBottles().NumWaterBottles( numBottles, numExchange );


    [TestCaseSource( nameof( TestCases ) )]
    public int NumWaterBottlesIterativeTest( int numBottles, int numExchange ) =>
        new WaterBottles().NumWaterBottlesIterative( numBottles, numExchange );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 9, 3 ).Returns( 13 );

            yield return new TestCaseData( 15, 4 ).Returns( 19 );

            yield return new TestCaseData( 5, 5 ).Returns( 6 );
        }
    }
}
