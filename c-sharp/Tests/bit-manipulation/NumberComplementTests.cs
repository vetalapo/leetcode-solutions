using NUnit.Framework;

using Problems;

public class NumberComplementTests
{
    [TestCase( 0, ExpectedResult = 1 )]
    [TestCase( 5, ExpectedResult = 2 )]
    [TestCase( 1, ExpectedResult = 0 )]
    public int FindComplementTest( int num ) =>
        new NumberComplement().FindComplement( num );
}
