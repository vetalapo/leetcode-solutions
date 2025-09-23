using NUnit.Framework;

using Problems;

namespace BitManipulation;

[TestFixture()]
public class MinimumOperationsToEqualizeArrayTests
{
    [TestCase( new int[] { 1, 2 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 5, 5, 5 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 103, 76 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 46 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 107, 107, 46, 91 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 72, 50, 72 }, ExpectedResult = 1 )]
    public int MinOperationsTest( int[] nums ) =>
        new MinimumOperationsToEqualizeArray().MinOperations( nums );
}
