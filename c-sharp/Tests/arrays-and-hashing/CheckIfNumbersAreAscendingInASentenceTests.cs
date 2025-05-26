using NUnit.Framework;

using Problems;

public class CheckIfNumbersAreAscendingInASentenceTests
{
    [TestCase( "1 box has 3 blue 4 red 6 green and 12 yellow marbles", ExpectedResult = true )]
    [TestCase( "hello world 5 x 5", ExpectedResult = false )]
    [TestCase( "sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s", ExpectedResult = false )]
    public bool AreNumbersAscendingTest( string s ) =>
        new CheckIfNumbersAreAscendingInASentence().AreNumbersAscending( s );
}
