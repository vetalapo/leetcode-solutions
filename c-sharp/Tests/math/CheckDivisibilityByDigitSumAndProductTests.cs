using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CheckDivisibilityByDigitSumAndProductTests
{
    [TestCase( 99, ExpectedResult = true )]
    [TestCase( 23, ExpectedResult = false )]
    public bool CheckDivisibilityTest( int n ) =>
        new CheckDivisibilityByDigitSumAndProduct().CheckDivisibility( n );
}
