using NUnit.Framework;

using Problems;

public class NumberOfChangingKeysTests
{
    [TestCase( "aAbBcC", ExpectedResult = 2 )]
    [TestCase( "AaAaAaaA", ExpectedResult = 0 )]
    [TestCase( "mDVD", ExpectedResult = 3 )]
    public int CountKeyChangesTest( string s ) =>
        new NumberOfChangingKeys().CountKeyChanges( s );
}
