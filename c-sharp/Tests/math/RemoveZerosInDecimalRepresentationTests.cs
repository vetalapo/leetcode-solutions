using NUnit.Framework;

using Problems;

namespace Mathematics;

public class RemoveZerosInDecimalRepresentationTests
{
    [TestCase( 1020030, ExpectedResult = 123 )]
    [TestCase( 1, ExpectedResult = 1 )]
    [TestCase( 11652754537, ExpectedResult = 11652754537 )]
    public long RemoveZerosTest( long n ) =>
        new RemoveZerosInDecimalRepresentation().RemoveZeros( n );
}
