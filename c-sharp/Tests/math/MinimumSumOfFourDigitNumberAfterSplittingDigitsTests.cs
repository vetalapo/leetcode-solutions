using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MinimumSumOfFourDigitNumberAfterSplittingDigitsTests
{
    [TestCase( 2932, ExpectedResult = 52 )]
    [TestCase( 4009, ExpectedResult = 13 )]
    public int MinimumSumTest( int num ) =>
        new MinimumSumOfFourDigitNumberAfterSplittingDigits().MinimumSum( num );
}
