using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class GenerateAStringWithCharactersThatHaveOddCountsTests
{
    [TestCase( 4 )]
    [TestCase( 2 )]
    [TestCase( 7 )]
    public void GenerateTheStringTest( int n )
    {
        string result = new GenerateAStringWithCharactersThatHaveOddCounts()
            .GenerateTheString( n );

        Assert.AreEqual( result.Length, n );

        Dictionary<char, int> countMap = [];

        foreach ( char c in result )
        {
            if ( !countMap.TryAdd( c, 1 ) )
            {
                countMap[c]++;
            }
        }

        foreach ( int count in countMap.Values )
        {
            Assert.AreEqual( count & 1, 1 );
        }
    }
}
