using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ThreeDivisorsTests
{
    [TestCase( 2, ExpectedResult = false )]
    [TestCase( 4, ExpectedResult = true )]
    [TestCase( 9409, ExpectedResult = true )]
    public bool IsThreeTest( int n ) =>
        new ThreeDivisors().IsThree( n );
}
