using NUnit.Framework;

using Problems;

public class SumOfAllSubsetXorTotalsTests
{
    [TestCase( new int[] { 1, 3 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 5, 1, 6 }, ExpectedResult = 28 )]
    [TestCase( new int[] { 3, 4, 5, 6, 7, 8 }, ExpectedResult = 480 )]
    public int SubsetXORSumTest( int[] nums ) =>
        new SumOfAllSubsetXorTotals().SubsetXORSum( nums );
}
