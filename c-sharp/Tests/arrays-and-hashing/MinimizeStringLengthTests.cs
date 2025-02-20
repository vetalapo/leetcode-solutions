using NUnit.Framework;

using Problems;

public class MinimizeStringLengthTests
{
    [TestCase( "aaabc", ExpectedResult = 3 )]
    [TestCase( "cbbd", ExpectedResult = 3 )]
    [TestCase( "baadccab", ExpectedResult = 4 )]
    public int MinimizedStringLengthTest( string s ) =>
        new MinimizeStringLength().MinimizedStringLength( s );
}
