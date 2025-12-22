using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MirrorDistanceOfAnIntegerTests
{
    [TestCase( 25, ExpectedResult = 27 )]
    [TestCase( 10, ExpectedResult = 9 )]
    [TestCase( 7, ExpectedResult = 0 )]
    [TestCase( 111, ExpectedResult = 0 )]
    public int MirrorDistanceTest( int n ) =>
        new MirrorDistanceOfAnInteger().MirrorDistance( n );
}
