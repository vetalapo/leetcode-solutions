using NUnit.Framework;

using Problems;

public class ReverseDegreeOfAStringTests
{
    [TestCase( "abc", ExpectedResult = 148 )]
    [TestCase( "zaza", ExpectedResult = 160 )]
    public int ReverseDegreeTest( string s ) =>
        new ReverseDegreeOfAString().ReverseDegree( s );
}
