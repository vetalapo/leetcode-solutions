using NUnit.Framework;

using Problems;

public class FindTheArrayConcatenationValueTests
{
    [TestCase( new int[] { 7, 52, 2, 4 }, ExpectedResult = 596 )]
    [TestCase( new int[] { 5, 14, 13, 8, 12 }, ExpectedResult = 673 )]
    public long FindTheArrayConcValTest( int[] nums ) =>
        new FindTheArrayConcatenationValue().FindTheArrayConcVal( nums );
}
