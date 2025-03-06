using NUnit.Framework;

using Problems;

public class AverageSalaryExcludingTheMinimumAndMaximumSalaryTests
{
    [TestCase( new int[] { 4000, 3000, 1000, 2000 }, ExpectedResult = 2500.0 )]
    [TestCase( new int[] { 1000, 2000, 3000 }, ExpectedResult = 2000.0 )]
    public double AverageTest( int[] salary ) =>
        new AverageSalaryExcludingTheMinimumAndMaximumSalary().Average( salary );
}
