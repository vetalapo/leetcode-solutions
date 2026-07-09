using NUnit.Framework;

using Problems;

namespace Mathematics;

public class SumOfCompatibleNumbersInRangeITests
{
    [TestCase( 2, 3, ExpectedResult = 10 )]
    [TestCase( 5, 1, ExpectedResult = 0 )]
    [TestCase( 1, 13, ExpectedResult = 56 )]
    public int SumOfGoodIntegers( int n, int k ) =>
        new SumOfCompatibleNumbersInRangeI().SumOfGoodIntegers( n, k );
}