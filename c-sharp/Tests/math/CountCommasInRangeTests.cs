using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CountCommasInRangeTests
{
    [TestCase( 1002, ExpectedResult = 3 )]
    [TestCase( 998, ExpectedResult = 0 )]
    public int CountCommasTest( int n ) =>
        new CountCommasInRange().CountCommas( n );
}
