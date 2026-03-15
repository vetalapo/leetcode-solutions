using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FirstUniqueEvenElementTests
{
    [TestCase( new int[] { 3, 4, 2, 5, 4, 6 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 4, 4 }, ExpectedResult = -1 )]
    public int FirstUniqueEvenTest( int[] nums ) =>
        new FirstUniqueEvenElement().FirstUniqueEven( nums );
}
