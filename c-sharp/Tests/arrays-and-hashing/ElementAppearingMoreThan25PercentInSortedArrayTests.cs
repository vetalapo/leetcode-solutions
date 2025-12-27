using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ElementAppearingMoreThan25PercentInSortedArrayTests
{
    [TestCase( new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 1, 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 1, 2, 2, 3, 3, 3, 3 }, ExpectedResult = 3 )]
    public int FindSpecialIntegerTest( int[] arr ) =>
        new ElementAppearingMoreThan25PercentInSortedArray().FindSpecialInteger( arr );
}
