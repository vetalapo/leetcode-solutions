using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class SortArrayByParitySolutionTests
{
    [TestCase( new int[] { 3, 1, 2, 4 }, ExpectedResult = new int[] { 2, 4, 1, 3 } )]
    [TestCase( new int[] { 0 }, ExpectedResult = new int[] { 0 } )]
    public int[] SortArrayByParityTest( int[] nums ) =>
        new SortArrayByParitySolution().SortArrayByParity( nums );
}
