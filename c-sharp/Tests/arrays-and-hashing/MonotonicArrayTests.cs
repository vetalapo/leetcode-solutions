using NUnit.Framework;

using Problems;

public class MonotonicArrayTests
{
    [TestCase( new int[] { 1, 2, 2, 3 }, ExpectedResult = true )]
    [TestCase( new int[] { 6, 5, 4, 4 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 3, 2 }, ExpectedResult = false )]
    public bool IsMonotonicTest( int[] nums ) =>
        new MonotonicArray().IsMonotonic( nums );
}
