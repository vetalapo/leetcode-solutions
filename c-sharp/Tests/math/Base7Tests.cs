using NUnit.Framework;

using Problems;

public class Base7Tests
{
    [TestCase( 100, ExpectedResult = "202" )]
    [TestCase( -7, ExpectedResult = "-10" )]
    [TestCase( 0, ExpectedResult = "0" )]
    [TestCase( -8, ExpectedResult = "-11" )]
    public string ConvertToBase7Test( int num ) =>
        new Base7().ConvertToBase7( num );
}
