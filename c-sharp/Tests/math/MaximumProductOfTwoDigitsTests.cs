using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MaximumProductOfTwoDigitsTests
{
    [TestCase( 31, ExpectedResult = 3 )]
    [TestCase( 22, ExpectedResult = 4 )]
    [TestCase( 124, ExpectedResult = 8 )]
    public int MaxProductTest( int n ) =>
        new MaximumProductOfTwoDigits().MaxProduct( n );
}
