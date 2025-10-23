using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckIfDigitsAreEqualInStringAfterOperationsITests
{
    [TestCase( "3902", ExpectedResult = true )]
    [TestCase( "34789", ExpectedResult = false )]
    public bool HasSameDigitsTest( string s ) =>
        new CheckIfDigitsAreEqualInStringAfterOperationsI().HasSameDigits( s );
}
