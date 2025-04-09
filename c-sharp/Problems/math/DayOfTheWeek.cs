/**
 * 1185
 * Day of the Week
 **
 * Given a date,
 * return the corresponding day of the week for that date.
 * The input is given as three integers
 * representing the day, month and year respectively.
 *
 * Return the answer as one of the following values
 * {
 *   "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
 * }.
 *
 * Example 1:
 *   Input: day = 31, month = 8, year = 2019
 *   Output: "Saturday"
 *
 * Example 2:
 *   Input: day = 18, month = 7, year = 1999
 *   Output: "Sunday"
 *
 * Example 3:
 *   Input: day = 15, month = 8, year = 1993
 *   Output: "Sunday"
 *
 * Constraints:
 *   • The given dates are valid dates between the years 1971 and 2100.
 *
 * Hint 1:
 *   Sum up the number of days for the years before the given year.
 *
 * Hint 2:
 *   Handle the case of a leap year.
 *
 * Hint 3:
 *   Find the number of days for each month of the given year.
 **
 * https://leetcode.com/problems/day-of-the-week/
***/

namespace Problems;

public class DayOfTheWeekSolution
{
    private readonly string[] _weekdays =
    [
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    ];

    public string DayOfTheWeek( int day, int month, int year )
    {
        // Based on Zeller's congruence algorithm
        if ( month < 3 )
        {
            year--;
            month += 12;
        }

        int h = (
            day +
            ( 31 * ( month - 2 ) ) / 12 +
            year +
            year / 4 -
            year / 100 +
            year / 400
        ) % 7;

        return this._weekdays[h];
    }
}
