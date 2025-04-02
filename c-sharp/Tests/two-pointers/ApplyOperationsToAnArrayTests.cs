using NUnit.Framework;

using Problems;

public class ApplyOperationsToAnArrayTests
{
    [TestCase( new int[] { 1, 2, 2, 1, 1, 0 }, ExpectedResult = new int[] { 1, 4, 2, 0, 0, 0 } )]
    [TestCase( new int[] { 0, 1 }, ExpectedResult = new int[] { 1, 0 } )]
    public int[] ApplyOperationsTest( int[] nums ) =>
        new ApplyOperationsToAnArray().ApplyOperations( nums );
}
