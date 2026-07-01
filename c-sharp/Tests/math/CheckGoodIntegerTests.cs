using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CheckGoodIntegerTests
{
    [TestCase( 1000, ExpectedResult = false )]
    [TestCase( 19, ExpectedResult = true )]
    public bool CheckGoodIntegerTest( int n ) =>
        new CheckGoodIntegerSolution().CheckGoodInteger( n );
}