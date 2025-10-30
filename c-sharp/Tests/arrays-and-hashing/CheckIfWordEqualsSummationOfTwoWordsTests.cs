using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckIfWordEqualsSummationOfTwoWordsTests
{
    [TestCase( "acb", "cba", "cdb", ExpectedResult = true )]
    [TestCase( "aaa", "a", "aab", ExpectedResult = false )]
    [TestCase( "aaa", "a", "aaaa", ExpectedResult = true )]
    public bool IsSumEqualTest( string firstWord, string secondWord, string targetWord ) =>
        new CheckIfWordEqualsSummationOfTwoWords().IsSumEqual( firstWord, secondWord, targetWord );
}
