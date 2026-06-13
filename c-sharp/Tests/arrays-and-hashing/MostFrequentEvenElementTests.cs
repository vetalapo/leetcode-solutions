using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MostFrequentEvenElementTests
{
    [TestCase( new int[] { 0, 1, 2, 2, 4, 4, 1 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 4, 4, 4, 9, 2, 4 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 29, 47, 21, 41, 13, 37, 25, 7 }, ExpectedResult = -1 )]
    public int MostFrequentEvenTest( int[] nums ) =>
        new MostFrequentEvenElement().MostFrequentEven( nums );
}