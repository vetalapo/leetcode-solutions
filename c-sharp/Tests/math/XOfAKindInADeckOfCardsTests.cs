using NUnit.Framework;

using Problems;

public class XOfAKindInADeckOfCardsTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 1, 1, 2, 2, 2, 3, 3 }, ExpectedResult = false )]
    [TestCase( new int[] { 1 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 1, 2, 2, 2, 2 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 }, ExpectedResult = true )]
    public bool HasGroupsSizeXTest( int[] deck ) =>
        new XOfAKindInADeckOfCards().HasGroupsSizeX( deck );
}
