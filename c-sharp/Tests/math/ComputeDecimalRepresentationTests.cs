using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ComputeDecimalRepresentationTests
{
    [TestCase( 537, ExpectedResult = new int[] { 500, 30, 7 } )]
    [TestCase( 102, ExpectedResult = new int[] { 100, 2 } )]
    [TestCase( 6, ExpectedResult = new int[] { 6 } )]
    public int[] DecimalRepresentationTest( int n ) =>
        new ComputeDecimalRepresentation().DecimalRepresentation( n );
}
