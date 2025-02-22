using NUnit.Framework;

using Problems;

public class DetermineIfStringHalvesAreAlikeTests
{
    [TestCase( "book", ExpectedResult = true )]
    [TestCase( "textbook", ExpectedResult = false )]
    public bool HalvesAreAlikeTest( string s ) =>
        new DetermineIfStringHalvesAreAlike().HalvesAreAlike( s );
}
