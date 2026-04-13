using System;

namespace Problems;

public class MinimumDistanceToTheTargetElement
{
    public int GetMinDistance( int[] nums, int target, int start )
    {
        int min = int.MaxValue;

        for ( int i = 0; i < nums.Length; i++ )
        {
            if ( nums[i] == target )
            {
                min = Math.Min( min, Math.Abs( i - start ) );
            }
        }

        return min;
    } 
}
