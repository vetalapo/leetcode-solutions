using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class UniqueMiddleElementTests
{
    [TestCase( new int[] { 1, 2, 3  }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 2 }, ExpectedResult = false )]
    public bool IsMiddleElementUnique( int[] nums ) =>
        new UniqueMiddleElement().IsMiddleElementUnique( nums );
}