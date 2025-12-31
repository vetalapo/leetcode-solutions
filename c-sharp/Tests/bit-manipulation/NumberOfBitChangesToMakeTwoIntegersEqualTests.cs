using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class NumberOfBitChangesToMakeTwoIntegersEqualTests
{
    [TestCase( 13, 4, ExpectedResult = 2 )]
    [TestCase( 21, 21, ExpectedResult = 0 )]
    [TestCase( 14, 13, ExpectedResult = -1 )]
    public int MinChangesTest( int n, int k ) =>
        new NumberOfBitChangesToMakeTwoIntegersEqual().MinChanges( n, k );
}
