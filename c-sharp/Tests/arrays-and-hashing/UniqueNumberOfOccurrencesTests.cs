using NUnit.Framework;

using Problems;

public class UniqueNumberOfOccurrencesTests
{
    [TestCase( new int[] { 1, 2, 2, 1, 1, 3 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2 }, ExpectedResult = false )]
    [TestCase( new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, ExpectedResult = true )]
    public bool UniqueOccurrencesTest( int[] arr ) =>
        new UniqueNumberOfOccurrences().UniqueOccurrences( arr );
}
