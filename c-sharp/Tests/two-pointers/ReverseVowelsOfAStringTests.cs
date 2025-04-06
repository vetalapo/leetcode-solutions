using NUnit.Framework;

using Problems;

public class ReverseVowelsOfAStringTests
{
    [TestCase( "IceCreAm", ExpectedResult = "AceCreIm" )]
    [TestCase( "leetcode", ExpectedResult = "leotcede" )]
    public string ReverseVowelsTest( string s ) =>
        new ReverseVowelsOfAString().ReverseVowels( s );
}
