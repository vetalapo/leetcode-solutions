using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ConcatenateNonZeroDigitsAndMultiplyBySumITests
{
    [TestCase( 10203004, ExpectedResult = 12340 )]
    [TestCase( 1000, ExpectedResult = 1 )]
    [TestCase( 65463628, ExpectedResult = 2618545120 )]
    public long SumAndMultiplyTest( int n ) =>
        new ConcatenateNonZeroDigitsAndMultiplyBySumI().SumAndMultiply( n );
}