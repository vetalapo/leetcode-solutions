using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckBalancedStringTests
{
    [TestCase( "1234", ExpectedResult = false )]
    [TestCase( "24123", ExpectedResult = true )]
    public bool IsBalancedTest( string num ) =>
        new CheckBalancedString().IsBalanced( num );
}
