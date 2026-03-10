using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountResiduePrefixesTests
{
    [TestCase( "abc", ExpectedResult = 2 )]
    [TestCase( "dd", ExpectedResult = 1 )]
    [TestCase( "bob", ExpectedResult = 2 )]
    [TestCase( "bbbb", ExpectedResult = 2 )]
    public int ResiduePrefixesTest( string s ) =>
        new CountResiduePrefixes().ResiduePrefixes( s );
}
