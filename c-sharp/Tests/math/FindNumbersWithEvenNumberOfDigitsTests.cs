using NUnit.Framework;

using Problems;

public class FindNumbersWithEvenNumberOfDigitsTests
{
    [TestCase( new int[] { 12, 345, 2, 6, 7896 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 555, 901, 482, 1771 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 100000 }, ExpectedResult = 1 )]
    public int FindNumbersTest( int[] nums ) =>
        new FindNumbersWithEvenNumberOfDigits().FindNumbers( nums );
}
