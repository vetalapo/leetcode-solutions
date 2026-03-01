using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class TrimTrailingVowelsSolutionTests
{
    [TestCase( "idea", ExpectedResult = "id" )]
    [TestCase( "day", ExpectedResult = "day" )]
    [TestCase( "aeiou", ExpectedResult = "" )]
    public string TrimTrailingVowelsTest( string s ) =>
        new TrimTrailingVowelsSolution().TrimTrailingVowels( s );
}
