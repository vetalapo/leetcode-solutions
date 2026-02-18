using NUnit.Framework;

using Problems;

namespace Mathematics;

public class NumberOfCommonFactorsTests
{
    [TestCase( 12, 6, ExpectedResult = 4 )]
    [TestCase( 25, 30, ExpectedResult = 2 )]
    public int CommonFactorsTest( int a, int b ) =>
        new NumberOfCommonFactors().CommonFactors( a, b );
}
