using NUnit.Framework;

using Problems;

public class NumberOfDifferentIntegersInAStringTests
{
    [TestCase( "a123bc34d8ef34", ExpectedResult = 3 )]
    [TestCase( "leet1234code234", ExpectedResult = 2 )]
    [TestCase( "a1b01c001", ExpectedResult = 1 )]
    public int NumDifferentIntegersTest( string word ) =>
        new NumberOfDifferentIntegersInAString().NumDifferentIntegers( word );
}
