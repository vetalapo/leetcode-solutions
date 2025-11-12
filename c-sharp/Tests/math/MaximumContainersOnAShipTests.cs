using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MaximumContainersOnAShipTests
{
    [TestCase( 2, 3, 15, ExpectedResult = 4 )]
    [TestCase( 3, 5, 20, ExpectedResult = 4 )]
    public int MaxContainersTest( int n, int w, int maxWeight ) =>
        new MaximumContainersOnAShip().MaxContainers( n, w, maxWeight );
}
