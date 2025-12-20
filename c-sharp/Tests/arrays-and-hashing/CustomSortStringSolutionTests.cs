using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CustomSortStringSolutionTests
{
    [TestCase( "cba", "abcd", ExpectedResult = "cbad" )]
    public string CustomSortStringTest( string order, string s ) =>
        new CustomSortStringSolution().CustomSortString( order, s );
}
