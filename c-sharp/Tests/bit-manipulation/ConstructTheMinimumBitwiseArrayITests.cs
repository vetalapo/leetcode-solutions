using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class ConstructTheMinimumBitwiseArrayITests
{
    [TestCase( new int[] { 2, 3, 5, 7 }, ExpectedResult = new int[] { -1, 1, 4, 3 } )]
    [TestCase( new int[] { 11, 13, 31 }, ExpectedResult = new int[] { 9, 12, 15 } )]
    public int[] MinBitwiseArrayTest( IList<int> nums ) =>
        new ConstructTheMinimumBitwiseArrayI().MinBitwiseArray( nums );
}
