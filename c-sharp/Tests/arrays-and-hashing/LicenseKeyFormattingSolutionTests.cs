using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class LicenseKeyFormattingSolutionTests
{
    [TestCase( "5F3Z-2e-9-w", 4, ExpectedResult = "5F3Z-2E9W" )]
    [TestCase( "2-5g-3-J", 2, ExpectedResult = "2-5G-3J" )]
    [TestCase( "aaaa", 2, ExpectedResult = "AA-AA" )]
    public string LicenseKeyFormattingTest( string s, int k ) =>
        new LicenseKeyFormattingSolution().LicenseKeyFormatting( s, k );
}
