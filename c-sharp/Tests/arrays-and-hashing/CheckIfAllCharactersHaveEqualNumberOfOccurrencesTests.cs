using NUnit.Framework;

using Problems;

public class CheckIfAllCharactersHaveEqualNumberOfOccurrencesTests
{
    [TestCase( "abacbc", ExpectedResult = true )]
    [TestCase( "aaabb", ExpectedResult = false )]
    [TestCase( "vvvvvvvvvvvvvvvvvvv", ExpectedResult = true )]
    public bool AreOccurrencesEqualTest( string s ) =>
        new CheckIfAllCharactersHaveEqualNumberOfOccurrences().AreOccurrencesEqual( s );
}
