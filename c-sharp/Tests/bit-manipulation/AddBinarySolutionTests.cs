using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class AddBinarySolutionTests
{
    [TestCase( "11", "1", ExpectedResult = "100" )]
    [TestCase( "1010", "1011", ExpectedResult = "10101" )]
    [TestCase( "1111", "1111", ExpectedResult = "11110" )]
    public string AddBinaryTest( string a, string b ) =>
        new AddBinarySolution().AddBinary( a, b );
}
