using NUnit.Framework;

using Problems;

public class NumberOfSegmentsInAStringTests
{
    [TestCase( "Hello, my name is John", ExpectedResult = 5 )]
    [TestCase( "Hello", ExpectedResult = 1 )]
    [TestCase( "                ", ExpectedResult = 0 )]
    public int CountSegmentsTest( string s ) =>
        new NumberOfSegmentsInAString().CountSegments( s );
}
