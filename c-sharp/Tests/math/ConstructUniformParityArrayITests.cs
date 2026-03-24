using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ConstructUniformParityArrayITests
{
    [TestCase( new int[] { 2, 3 }, ExpectedResult = true )]
    [TestCase( new int[] { 4, 6 }, ExpectedResult = true )]
    public bool UniformArrayTest( int[] nums1 ) =>
        new ConstructUniformParityArrayI().UniformArray( nums1 );
}
