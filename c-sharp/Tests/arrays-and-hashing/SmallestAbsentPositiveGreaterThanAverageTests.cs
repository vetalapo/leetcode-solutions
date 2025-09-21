using NUnit.Framework;

using Problems;

public class SmallestAbsentPositiveGreaterThanAverageTests
{
    [TestCase( new int[] { 3, 5 }, ExpectedResult = 6 )]
    [TestCase( new int[] { -1, 1, 2 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 4, -1 }, ExpectedResult = 2 )]
    [TestCase( new int[] { -34 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 98, 100 }, ExpectedResult = 101 )]
    public int SmallestAbsentTest( int[] nums ) =>
        new SmallestAbsentPositiveGreaterThanAverage().SmallestAbsent( nums );
}
