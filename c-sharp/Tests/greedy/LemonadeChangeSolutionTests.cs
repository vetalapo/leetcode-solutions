using NUnit.Framework;

using Problems;

public class LemonadeChangeSolutionTests
{
    [TestCase( new int[] { 5, 5, 5, 10, 20 }, ExpectedResult = true )]
    [TestCase( new int[] { 5, 5, 10, 10, 20 }, ExpectedResult = false )]
    public bool LemonadeChangeTest( int[] bills ) =>
        new LemonadeChangeSolution().LemonadeChange( bills );
}
