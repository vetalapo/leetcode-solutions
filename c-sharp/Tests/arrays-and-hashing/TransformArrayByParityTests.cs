using NUnit.Framework;

using Problems;

public class TransformArrayByParityTests
{
    [TestCase( new int[] { 4, 3, 2, 1 }, ExpectedResult = new int[] { 0, 0, 1, 1 } )]
    [TestCase( new int[] { 1, 5, 1, 4, 2 }, ExpectedResult = new int[] { 0, 0, 1, 1, 1 } )]
    public int[] TransformArrayTest( int[] nums ) =>
        new TransformArrayByParity().TransformArray( nums );
}
