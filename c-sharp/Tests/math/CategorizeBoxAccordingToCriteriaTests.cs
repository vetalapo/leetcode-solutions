using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CategorizeBoxAccordingToCriteriaTests
{
    [TestCase( 1000, 35, 700, 300, ExpectedResult = "Heavy" )]
    [TestCase( 200, 50, 800, 50, ExpectedResult = "Neither" )]
    [TestCase( 2909, 3968, 3272, 727, ExpectedResult = "Both" )]
    public string CategorizeBoxTest( int length, int width, int height, int mass ) =>
        new CategorizeBoxAccordingToCriteria().CategorizeBox( length, width, height, mass );
}
