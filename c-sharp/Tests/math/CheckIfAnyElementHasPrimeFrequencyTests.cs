using NUnit.Framework;

using Problems;

public class CheckIfAnyElementHasPrimeFrequencyTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5, 4 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = false )]
    [TestCase( new int[] { 2, 2, 2, 4, 4 }, ExpectedResult = true )]
    [TestCase( new int[] { 3, 0, 3, 6, 3, 3 }, ExpectedResult = false )]
    public bool CheckPrimeFrequencyTest( int[] nums ) =>
        new CheckIfAnyElementHasPrimeFrequency().CheckPrimeFrequency( nums );
}
