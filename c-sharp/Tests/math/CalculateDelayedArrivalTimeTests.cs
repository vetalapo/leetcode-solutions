using NUnit.Framework;

using Problems;

public class CalculateDelayedArrivalTimeTests
{
    [TestCase( 15, 5, ExpectedResult = 20 )]
    [TestCase( 13, 11, ExpectedResult = 0 )]
    public int FindDelayedArrivalTimeTest( int arrivalTime, int delayedTime ) =>
        new CalculateDelayedArrivalTime().FindDelayedArrivalTime( arrivalTime, delayedTime );
}
