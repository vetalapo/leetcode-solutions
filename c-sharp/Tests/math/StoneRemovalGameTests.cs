using NUnit.Framework;

using Problems;

namespace Mathematics;

public class StoneRemovalGameTests
{
    [TestCase( 1, ExpectedResult = false )]
    [TestCase( 12, ExpectedResult = true )]
    [TestCase( 19, ExpectedResult = false )]
    public bool CanAliceWinTest( int n ) =>
        new StoneRemovalGame().CanAliceWin( n );
}
