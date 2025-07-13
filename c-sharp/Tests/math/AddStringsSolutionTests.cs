using NUnit.Framework;

using Problems;

public class AddStringsSolutionTests
{
    [TestCase( "11", "123", ExpectedResult = "134" )]
    [TestCase( "456", "77", ExpectedResult = "533" )]
    [TestCase( "0", "0", ExpectedResult = "0" )]
    [TestCase( "1", "9", ExpectedResult = "10" )]
    [TestCase( "123", "456", ExpectedResult = "579" )]
    public string AddStringsTest( string num1, string num2 ) =>
        new AddStringsSolution().AddStrings( num1, num2 );
}
