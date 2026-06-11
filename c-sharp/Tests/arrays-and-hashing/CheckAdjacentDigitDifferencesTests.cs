using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckAdjacentDigitDifferencesTests
{
    [TestCase( "132", ExpectedResult = true )]
    [TestCase( "129", ExpectedResult = false )]
    public bool IsAdjacentDiffAtMostTwoTest( string s ) =>
        new CheckAdjacentDigitDifferences().IsAdjacentDiffAtMostTwo( s );
}