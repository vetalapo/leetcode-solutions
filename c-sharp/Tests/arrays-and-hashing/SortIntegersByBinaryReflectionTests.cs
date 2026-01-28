using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SortIntegersByBinaryReflectionTests
{
    [TestCase( new int[] { 4, 5, 4 }, ExpectedResult = new int[] { 4, 4, 5 } )]
    [TestCase( new int[] { 3, 6, 5, 8 }, ExpectedResult = new int[] { 8, 3, 6, 5 } )]
    [TestCase( new int[] { 8, 2 }, ExpectedResult = new int[] { 2, 8 } )]
    public int[] SortByReflectionTest( int[] nums ) =>
        new SortIntegersByBinaryReflection().SortByReflection( nums );
}
