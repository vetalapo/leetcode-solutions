using NUnit.Framework;

using Problems;

public class RemoveOneElementToMakeTheArrayStrictlyIncreasingTests
{
    [TestCase( new int[] { 1, 2, 10, 5, 7 }, ExpectedResult = true )]
    [TestCase( new int[] { 2, 3, 1, 2 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 1, 1 }, ExpectedResult = false )]
    [TestCase( new int[] { 105, 924, 32, 968 }, ExpectedResult = true )]
    public bool CanBeIncreasingTest( int[] nums ) =>
        new RemoveOneElementToMakeTheArrayStrictlyIncreasing().CanBeIncreasing( nums );
}
