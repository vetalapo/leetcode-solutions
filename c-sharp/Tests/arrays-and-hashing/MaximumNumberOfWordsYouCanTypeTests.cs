using NUnit.Framework;

using Problems;

public class MaximumNumberOfWordsYouCanTypeTests
{
    [TestCase( "hello world", "ad", ExpectedResult = 1 )]
    [TestCase( "leet code", "lt", ExpectedResult = 1 )]
    [TestCase( "leet code", "e", ExpectedResult = 0 )]
    public int CanBeTypedWordsTest( string text, string brokenLetters ) =>
        new MaximumNumberOfWordsYouCanType().CanBeTypedWords( text, brokenLetters );
}
