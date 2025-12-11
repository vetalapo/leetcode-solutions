using NUnit.Framework;

using Problems;

namespace Mathematics;

public class LatestTimeYouCanObtainAfterReplacingCharactersTests
{
    [TestCase( "1?:?4", ExpectedResult = "11:54" )]
    [TestCase( "0?:5?", ExpectedResult = "09:59" )]
    [TestCase( "??:1?", ExpectedResult = "11:19" )]
    public string FindLatestTimeTest( string s ) =>
        new LatestTimeYouCanObtainAfterReplacingCharacters().FindLatestTime( s );
}
