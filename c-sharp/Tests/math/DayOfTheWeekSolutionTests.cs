using NUnit.Framework;

using Problems;

public class DayOfTheWeekSolutionTests
{
    [TestCase( 31, 8, 2019, ExpectedResult = "Saturday" )]
    [TestCase( 18, 7, 1999, ExpectedResult = "Sunday" )]
    [TestCase( 15, 8, 1993, ExpectedResult = "Sunday" )]
    [TestCase( 29, 2, 2016, ExpectedResult = "Monday" )]
    public string DayOfTheWeekTest( int day, int month, int year ) =>
        new DayOfTheWeekSolution().DayOfTheWeek( day, month, year );
}
