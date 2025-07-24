using NUnit.Framework;

using Problems;

public class IsSubsequenceSolutionTests
{
    [TestCase( "abc", "ahbgdc", ExpectedResult = true )]
    [TestCase( "axc", "ahbgdc", ExpectedResult = false )]
    [TestCase( "acb", "ahbgdc", ExpectedResult = false )]
    [TestCase( "", "ahbgdc", ExpectedResult = true )]
    public bool IsSubsequenceTest( string s, string t ) =>
        new IsSubsequenceSolution().IsSubsequence( s, t );
}
