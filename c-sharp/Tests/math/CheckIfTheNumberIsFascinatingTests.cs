using NUnit.Framework;

using Problems;

public class CheckIfTheNumberIsFascinatingTests
{
    [TestCase( 192, ExpectedResult = true )]
    [TestCase( 100, ExpectedResult = false )]
    [TestCase( 219, ExpectedResult = true )]
    [TestCase( 250, ExpectedResult = false )]
    [TestCase( 273, ExpectedResult = true )]
    [TestCase( 300, ExpectedResult = false )]
    [TestCase( 327, ExpectedResult = true )]
    [TestCase( 999, ExpectedResult = false )]
    public bool IsFascinatingTest( int n ) =>
        new CheckIfTheNumberIsFascinating().IsFascinating( n );
}
