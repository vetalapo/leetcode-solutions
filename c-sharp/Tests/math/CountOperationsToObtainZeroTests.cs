using NUnit.Framework;

using Problems;

public class CountOperationsToObtainZeroTests
{
    [TestCase( 2, 3, ExpectedResult = 3 )]
    [TestCase( 10, 10, ExpectedResult = 1 )]
    public int CountOperationsTest( int num1, int num2 ) =>
        new CountOperationsToObtainZero().CountOperations( num1, num2 );
}
