using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ToggleLightBulbsSolutionTests
{
    [TestCase( new int[] { 10, 30, 20, 10 }, ExpectedResult = new int[] { 20, 30 } )]
    [TestCase( new int[] { 100, 100 }, ExpectedResult = new int[0] )]
    public IList<int> ToggleLightBulbsTest( IList<int> bulbs ) =>
        new ToggleLightBulbsSolution().ToggleLightBulbs( bulbs );
}
