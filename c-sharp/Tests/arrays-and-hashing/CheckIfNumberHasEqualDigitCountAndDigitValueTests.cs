using NUnit.Framework;

using Problems;

public class CheckIfNumberHasEqualDigitCountAndDigitValueTests
{
    [TestCase( "1210", ExpectedResult = true )]
    [TestCase( "030", ExpectedResult = false )]
    public bool DigitCountTest( string num ) =>
        new CheckIfNumberHasEqualDigitCountAndDigitValue().DigitCount( num );
}
