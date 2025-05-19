using NUnit.Framework;

using Problems;

public class ValidPalindromeIITests
{
    [TestCase( "aba", ExpectedResult = true )]
    [TestCase( "abca", ExpectedResult = true )]
    [TestCase( "abc", ExpectedResult = false )]
    [TestCase( "lcupuupucul", ExpectedResult = true )]
    [TestCase( "adffdslcupuupuculsdffda", ExpectedResult = true )]
    [TestCase( "deddde", ExpectedResult = true )]
    public bool ValidPalindromeTest( string s ) =>
        new ValidPalindromeII().ValidPalindrome( s );
}
