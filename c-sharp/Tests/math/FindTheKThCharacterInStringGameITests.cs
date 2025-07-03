using NUnit.Framework;

using Problems;

public class FindTheKThCharacterInStringGameITests
{
    [TestCase( 5, ExpectedResult = 'b' )]
    [TestCase( 10, ExpectedResult = 'c' )]
    public char KthCharacterTest( int k ) =>
        new FindTheKThCharacterInStringGameI().KthCharacter( k );
}
