using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CountDigitAppearancesTests
{
    [TestCase( new int[] { 12, 54, 32, 22 }, 2, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 34, 7 }, 9, ExpectedResult = 0 )]
    public int CountDigitOccurrencesTest( int[] nums, int digit ) =>
        new CountDigitAppearances().CountDigitOccurrences( nums, digit );
}