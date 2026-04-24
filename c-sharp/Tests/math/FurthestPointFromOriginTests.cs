using NUnit.Framework;

using Problems;

namespace Mathematics;

public class FurthestPointFromOriginTests
{
    [TestCase( "L_RL__R", ExpectedResult = 3 )]
    [TestCase( "_R__LL_", ExpectedResult = 5 )]
    [TestCase( "_______", ExpectedResult = 7 )]
    public int FurthestDistanceFromOriginTest( string moves ) =>
        new FurthestPointFromOrigin().FurthestDistanceFromOrigin( moves );
}
