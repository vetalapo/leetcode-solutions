using NUnit.Framework;

using Problems;

public class TotalDistanceTraveledTests
{
    [TestCase( 5, 10, ExpectedResult = 60 )]
    [TestCase( 1, 2, ExpectedResult = 10 )]
    [TestCase( 9, 2, ExpectedResult = 110 )]
    public int DistanceTraveledTest( int mainTank, int additionalTank ) =>
        new TotalDistanceTraveled().DistanceTraveled( mainTank, additionalTank );
}
