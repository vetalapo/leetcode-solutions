using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SumOfGoodNumbersSolutionTests
{
    [TestCase( new int[] { 1, 3, 2, 1, 5, 4 }, 2, ExpectedResult = 12 )]
    [TestCase( new int[] { 2, 1 }, 1, ExpectedResult = 2 )]
    public int SumOfGoodNumbersTest( int[] nums, int k ) =>
        new SumOfGoodNumbersSolution().SumOfGoodNumbers( nums, k );
}
