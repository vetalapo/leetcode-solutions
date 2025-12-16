using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountTheNumberOfVowelStringsInRangeTests
{
    [TestCase( [new string[] { "are", "amy", "u" }, 0, 2], ExpectedResult = 2 )]
    [TestCase( [new string[] { "hey", "aeo", "mu", "ooo", "artro" }, 1, 4], ExpectedResult = 3 )]
    public int VowelStringsTest( string[] words, int left, int right ) =>
        new CountTheNumberOfVowelStringsInRange().VowelStrings( words, left, right );
}
