using NUnit.Framework;

using Problems;

namespace Mathematics;

public class DivisorGameSolutionTests
{
    [TestCase( 2, ExpectedResult = true )]
    [TestCase( 3, ExpectedResult = false )]
    public bool DivisorGameTest( int n ) =>
        new DivisorGameSolution().DivisorGame( n );
}
