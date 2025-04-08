using NUnit.Framework;

using Problems;

public class ThreeConsecutiveOddsSolutionTests
{
    [TestCase( new int[] { 2, 6, 4, 1 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, ExpectedResult = true )]
    public bool ThreeConsecutiveOddsTest( int[] arr ) =>
        new ThreeConsecutiveOddsSolution().ThreeConsecutiveOdds( arr );
}
