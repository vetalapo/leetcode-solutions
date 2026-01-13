using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ReverseStringPrefixTests
{
    [TestCase( "abcd", 2, ExpectedResult = "bacd" )]
    [TestCase( "xyz", 3, ExpectedResult = "zyx" )]
    [TestCase( "hey", 1, ExpectedResult = "hey" )]
    public string ReversePrefixTest( string s, int k ) =>
        new ReverseStringPrefix().ReversePrefix( s, k );
}
