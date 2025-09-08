using NUnit.Framework;

using Problems;

public class ConvertIntegerToTheSumOfTwoNoZeroIntegersTests
{
    [TestCase( 2, ExpectedResult = new int[] { 1, 1 } )]
    [TestCase( 11, ExpectedResult = new int[] { 2, 9 } )]
    public int[] GetNoZeroIntegersTest( int n ) =>
        new ConvertIntegerToTheSumOfTwoNoZeroIntegers().GetNoZeroIntegers( n );
}
