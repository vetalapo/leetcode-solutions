using NUnit.Framework;

using Problems;

public class ValidPerfectSquareTests
{
    [TestCase( 16, ExpectedResult = true )]
    [TestCase( 14, ExpectedResult = false )]
    public bool IsPerfectSquareTest( int num ) =>
        new ValidPerfectSquare().IsPerfectSquare( num );
}
