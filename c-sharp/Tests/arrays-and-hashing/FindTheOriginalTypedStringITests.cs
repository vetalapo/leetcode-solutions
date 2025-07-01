using NUnit.Framework;

using Problems;

public class FindTheOriginalTypedStringITests
{
    [TestCase( "abbcccc", ExpectedResult = 5 )]
    [TestCase( "abcd", ExpectedResult = 1 )]
    [TestCase( "aaaa", ExpectedResult = 4 )]
    public int PossibleStringCountTest( string word ) =>
        new FindTheOriginalTypedStringI().PossibleStringCount( word );
}
