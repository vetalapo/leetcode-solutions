using NUnit.Framework;

using Problems;

public class ReplaceAllDigitsWithCharactersTests
{
    [TestCase( "a1c1e1", ExpectedResult = "abcdef" )]
    [TestCase( "a1b2c3d4e", ExpectedResult = "abbdcfdhe" )]
    public string ReplaceDigitsTest( string s ) =>
        new ReplaceAllDigitsWithCharacters().ReplaceDigits( s );
}
