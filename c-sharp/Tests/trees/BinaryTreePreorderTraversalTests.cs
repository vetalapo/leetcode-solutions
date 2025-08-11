using System;
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class BinaryTreePreorderTraversalTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<int> PreorderTraversalTest( TreeNode root ) =>
        new BinaryTreePreorderTraversal().PreorderTraversal( root );

    [TestCaseSource( nameof( TestCases ) )]
    public IList<int> PreorderTraversalIterativeTest( TreeNode root ) =>
        new BinaryTreePreorderTraversal().PreorderTraversalIterative( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [1, null, 2, 3] ) )
                .Returns( new int[] { 1, 2, 3 } );

            yield return new TestCaseData( TreeNode.Create( [1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9] ) )
                .Returns( new int[] { 1, 2, 4, 5, 6, 7, 3, 8, 9 } );

            yield return new TestCaseData( TreeNode.Create( [] ) )
                .Returns( Array.Empty<int>() );

            yield return new TestCaseData( TreeNode.Create( [1] ) )
                .Returns( new int[] { 1 } );
        }
    }
}
