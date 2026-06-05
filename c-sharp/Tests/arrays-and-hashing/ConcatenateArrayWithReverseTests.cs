using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ConcatenateArrayWithReverseTests
{
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3, 3, 2, 1 } )]
    [TestCase( new int[] { 1 }, ExpectedResult = new int[] { 1, 1 } )]
    public int[] ConcatWithReverseTest( int[] nums ) =>
      new ConcatenateArrayWithReverse().ConcatWithReverse( nums );
}