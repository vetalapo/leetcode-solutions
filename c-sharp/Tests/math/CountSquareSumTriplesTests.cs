using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CountSquareSumTriplesTests
{
    [TestCase( 5, ExpectedResult = 2 )]
    [TestCase( 10, ExpectedResult = 4 )]
    [TestCase( 12, ExpectedResult = 4 )]
    [TestCase( 18, ExpectedResult = 10 )]
    [TestCase( 41, ExpectedResult = 34 )]
    public int CountTriplesTest( int n ) =>
        new CountSquareSumTriples().CountTriples( n );
}
