using NUnit.Framework;

using Problems;

public class CanPlaceFlowersSolutionTests
{
    [TestCase( new int[] { 1, 0, 0, 0, 1 }, 1, ExpectedResult = true )]
    [TestCase( new int[] { 1, 0, 0, 0, 1 }, 2, ExpectedResult = false )]
    [TestCase( new int[] { 1, 0, 0, 0, 0, 1 }, 2, ExpectedResult = false )]
    [TestCase( new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 1 }, 3, ExpectedResult = true )]
    [TestCase( new int[] { 0, 0, 1, 0, 1 }, 1, ExpectedResult = true )]
    public bool CanPlaceFlowersTest( int[] flowerbed, int n ) =>
        new CanPlaceFlowersSolution().CanPlaceFlowers( flowerbed, n );
}
