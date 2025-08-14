using NUnit.Framework;

using Problems;

public class Largest3SameDigitNumberInStringTests
{
    [TestCase( "6777133339", ExpectedResult = "777" )]
    [TestCase( "2300019", ExpectedResult = "000" )]
    [TestCase( "42352338", ExpectedResult = "" )]
    public string LargestGoodIntegerTest( string num ) =>
        new Largest3SameDigitNumberInString().LargestGoodInteger( num );
}
