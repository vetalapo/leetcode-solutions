using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class LongPressedNameTests
{
    [TestCase( "alex", "aaleex", ExpectedResult = true )]
    [TestCase( "saeed", "ssaaedd", ExpectedResult = false )]
    [TestCase( "alex", "aaleexa", ExpectedResult = false )]
    [TestCase( "alexd", "ale", ExpectedResult = false )]
    [TestCase( "pyplrz", "ppyypllr", ExpectedResult = false )]
    public bool IsLongPressedNameTest( string name, string typed ) =>
        new LongPressedName().IsLongPressedName( name, typed );
}
