using NUnit.Framework;

using Problems;

public class TypeOfTriangleTests
{
    [TestCase( new int[] { 3, 3, 3 }, ExpectedResult = "equilateral" )]
    [TestCase( new int[] { 3, 4, 5 }, ExpectedResult = "scalene" )]
    public string TriangleTypeTest( int[] nums ) =>
        new TypeOfTriangle().TriangleType( nums );
}
