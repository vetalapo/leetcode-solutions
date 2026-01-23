using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class VowelConsonantScoreSolutionTests
{
    [TestCase( "cooear", ExpectedResult = 2 )]
    [TestCase( "axeyizou", ExpectedResult = 1 )]
    [TestCase( "au 123", ExpectedResult = 0 )]
    [TestCase( "a", ExpectedResult = 0 )]
    [TestCase( "i3", ExpectedResult = 0 )]
    public int VowelConsonantScoreTest( string s ) =>
        new VowelConsonantScoreSolution().VowelConsonantScore( s );
}
