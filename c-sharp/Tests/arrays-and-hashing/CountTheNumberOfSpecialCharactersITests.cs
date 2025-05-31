using NUnit.Framework;

using Problems;

public class CountTheNumberOfSpecialCharactersITests
{
    [TestCase( "aaAbcBC", ExpectedResult = 3 )]
    [TestCase( "abc", ExpectedResult = 0 )]
    [TestCase( "abBCab", ExpectedResult = 1 )]
    public int NumberOfSpecialCharsTest( string word ) =>
        new CountTheNumberOfSpecialCharactersI().NumberOfSpecialChars( word );
}
