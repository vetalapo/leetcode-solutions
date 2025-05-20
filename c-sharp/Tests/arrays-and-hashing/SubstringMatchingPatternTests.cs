using NUnit.Framework;

using Problems;

public class SubstringMatchingPatternTests
{
    [TestCase( "leetcode", "ee*e", ExpectedResult = true )]
    [TestCase( "car", "c*v", ExpectedResult = false )]
    [TestCase( "luck", "u*", ExpectedResult = true )]
    public bool HasMatchTest( string s, string p ) =>
        new SubstringMatchingPattern().HasMatch( s, p );
}
