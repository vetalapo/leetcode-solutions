﻿using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.stack.Tests;

[TestFixture]
public class LargestRectangleInHistogramTests
{
    [TestCaseSource( typeof( LargestRectangleInHistogramTests ), nameof( TestCases ) )]
    public int LargestRectangleAreaTest( int[] heights ) => new LargestRectangleInHistogram().LargestRectangleArea( heights );

    [TestCaseSource( typeof( LargestRectangleInHistogramTests ), nameof( TestCases ) )]
    public int LargestRectangleAreaOneLoopTest( int[] heights ) => new LargestRectangleInHistogram().LargestRectangleAreaOneLoop( heights );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 2, 1, 5, 6, 2, 3 } ).Returns( 10 );
            yield return new TestCaseData( new int[] { 2, 4 } ).Returns( 4 );
        }
    }
}