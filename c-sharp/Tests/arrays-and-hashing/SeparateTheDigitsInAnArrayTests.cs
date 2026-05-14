using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SeparateTheDigitsInAnArrayTests
{
    [TestCase( new int[] { 13, 25, 83, 77 }, ExpectedResult = new int[] { 1, 3, 2, 5, 8, 3, 7, 7 } )]
    [TestCase( new int[] { 7, 1, 3, 9 }, ExpectedResult = new int[] { 7, 1, 3, 9 } )]
    public int[] SeparateDigitsTest( int[] nums ) =>
        new SeparateTheDigitsInAnArray().SeparateDigits( nums );
}