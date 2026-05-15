using NUnit.Framework;

using Problems;

namespace Greedy;

public class TwoFurthestHousesWithDifferentColorsTests
{
    [TestCase( new int[] { 1, 1, 1, 6, 1, 1, 1 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 1, 8, 3, 8, 3 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 0, 1 }, ExpectedResult = 1 )]
    public int MaxDistanceTest( int[] colors ) =>
        new  TwoFurthestHousesWithDifferentColors().MaxDistance( colors );
}