using NUnit.Framework;

using Problems;

public class HappyNumberTests
{
    [TestCase( 19, ExpectedResult = true )]
    [TestCase( 2, ExpectedResult = false )]
    [TestCase( 3, ExpectedResult = false )]
    public bool IsHappyTest( int n ) =>
        new HappyNumber().IsHappy( n );
}
