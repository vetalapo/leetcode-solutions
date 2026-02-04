using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class CountMonobitIntegersTests
{
    [TestCase( 1, ExpectedResult = 2 )]
    [TestCase( 4, ExpectedResult = 3 )]
    [TestCase( 5, ExpectedResult = 3 )]
    public int CountMonobitTest( int n ) =>
        new CountMonobitIntegers().CountMonobit( n );
}
