using NUnit.Framework;

using Problems;

public class ThousandSeparatorSolutionTests
{
    [TestCase( 987, ExpectedResult = "987" )]
    [TestCase( 1234, ExpectedResult = "1.234" )]
    [TestCase( 0, ExpectedResult = "0" )]
    public string ThousandSeparatorTest( int n ) =>
        new ThousandSeparatorSolution().ThousandSeparator( n );
}