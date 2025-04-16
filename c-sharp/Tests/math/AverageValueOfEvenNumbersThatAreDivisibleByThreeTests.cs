using NUnit.Framework;

using Problems;

public class AverageValueOfEvenNumbersThatAreDivisibleByThreeTests
{
    [TestCase( new int[] { 1, 3, 6, 10, 12, 15 }, ExpectedResult = 9 )]
    [TestCase( new int[] { 1, 2, 4, 7, 10 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 4, 4, 9, 10 }, ExpectedResult = 0 )]
    public int AverageValueTest( int[] nums ) =>
        new AverageValueOfEvenNumbersThatAreDivisibleByThree().AverageValue( nums );
}
