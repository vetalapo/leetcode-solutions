using NUnit.Framework;

using Problems;

public class TrafficSignalColorTests
{
    [TestCase( 60, ExpectedResult = "Red" )]
    [TestCase( 5, ExpectedResult = "Invalid" )]
    public string TrafficSignal( int timer ) =>
        new TrafficSignalColor().TrafficSignal( timer );
}
