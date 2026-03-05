using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class MinimumChangesToMakeAlternatingBinaryStringTests
{
    [TestCase( "0100", ExpectedResult = 1 )]
    [TestCase( "10", ExpectedResult = 0 )]
    [TestCase( "1111", ExpectedResult = 2 )]
    [TestCase( "110010", ExpectedResult = 2 )]
    [TestCase( "10010100", ExpectedResult = 3 )]
    public int MinOperationsTest( string s ) =>
        new MinimumChangesToMakeAlternatingBinaryString().MinOperations( s );
}
