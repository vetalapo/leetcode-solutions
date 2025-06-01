using NUnit.Framework;

using Problems;

public class ValidWordTests
{
    [TestCase( "234Adas", ExpectedResult = true )]
    [TestCase( "b3", ExpectedResult = false )]
    [TestCase( "a3$e", ExpectedResult = false )]
    [TestCase( "UuE6", ExpectedResult = false )]
    public bool IsValidTest( string word ) =>
        new ValidWord().IsValid( word );
}
