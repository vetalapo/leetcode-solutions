using NUnit.Framework;

using Problems;

public class CheckIfAllAAppearsBeforeAllBTests
{
    [TestCase( "aaabbb", ExpectedResult = true )]
    [TestCase( "abab", ExpectedResult = false )]
    [TestCase( "bbb", ExpectedResult = true )]
    [TestCase( "aaa", ExpectedResult = true )]
    public bool CheckStringTest( string s ) =>
        new CheckIfAllAAppearsBeforeAllB().CheckString( s );
}
