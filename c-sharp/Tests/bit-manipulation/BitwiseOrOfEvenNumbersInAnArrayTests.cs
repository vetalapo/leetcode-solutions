using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class BitwiseOrOfEvenNumbersInAnArrayTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 7, 9, 11 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 8, 16 }, ExpectedResult = 24 )]
    public int EvenNumberBitwiseORsTest( int[] nums ) =>
        new BitwiseOrOfEvenNumbersInAnArray().EvenNumberBitwiseORs( nums );
}
