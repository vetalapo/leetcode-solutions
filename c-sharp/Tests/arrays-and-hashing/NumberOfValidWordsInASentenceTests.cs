using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class NumberOfValidWordsInASentenceTests
{
    [TestCase( "cat and  dog", ExpectedResult = 3 )]
    [TestCase( "!this  1-s b8d!", ExpectedResult = 0 )]
    [TestCase( "alice and  bob are playing stone-game10", ExpectedResult = 5 )]
    [TestCase( "he bought 2 pencils, 3 erasers, and 1  pencil-sharpener.", ExpectedResult = 6 )]
    [TestCase( " o6 t", ExpectedResult = 1 )]
    [TestCase( "a-b-c", ExpectedResult = 0 )]
    public int CountValidWordsTest( string sentence ) =>
        new NumberOfValidWordsInASentence().CountValidWords( sentence );
}
