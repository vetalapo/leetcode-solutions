using NUnit.Framework;

using Problems;

public class ValidMountainArraySolutionTests
{
    [TestCase( new int[] { 2, 1 }, ExpectedResult = false )]
    [TestCase( new int[] { 3, 5, 5 }, ExpectedResult = false )]
    [TestCase( new int[] { 0, 3, 2, 1 }, ExpectedResult = true )]
    [TestCase( new int[] { 2, 1, 2, 3, 5, 7, 9, 10, 12, 14, 15, 16, 18, 14, 13 }, ExpectedResult = false )]
    [TestCase( new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, ExpectedResult = false )]
    public bool ValidMountainArrayTest( int[] arr ) =>
        new ValidMountainArraySolution().ValidMountainArray( arr );
}
