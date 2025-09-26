using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CountSymmetricIntegersSolutionTests
{
    [TestCase( 1, 100, ExpectedResult = 9 )]
    [TestCase( 1200, 1230, ExpectedResult = 4 )]
    [TestCase( 100, 1000, ExpectedResult = 0 )]
    public int CountSymmetricIntegersTest( int low, int high ) =>
        new CountSymmetricIntegersSolution().CountSymmetricIntegers( low, high );
}
