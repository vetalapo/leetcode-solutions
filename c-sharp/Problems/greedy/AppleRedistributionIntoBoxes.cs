/**
 * 3074
 * Apple Redistribution into Boxes
 **
 * You are given an array apple of size n and an array capacity of size m.
 *
 * There are n packs where the ith pack contains apple[i] apples.
 * There are m boxes as well,
 * and the ith box has a capacity of capacity[i] apples.
 *
 * Return the minimum number of boxes
 * you need to select to redistribute these n packs of apples into boxes.
 *
 * Note that,
 * apples from the same pack can be distributed into different boxes.
 *
 * Example 1:
 *   Input: apple = [1,3,2], capacity = [4,3,1,5,2]
 *   Output: 2
 *   Explanation:
 *     We will use boxes with capacities 4 and 5.
 *     It is possible to distribute the apples
 *     as the total capacity is greater than or equal to
 *     the total number of apples.
 *
 * Example 2:
 *   Input: apple = [5,5,5], capacity = [2,4,2,7]
 *   Output: 4
 *   Explanation:
 *     We will need to use all the boxes.
 *
 * Constraints:
 *   • 1 <= n == apple.length <= 50
 *   • 1 <= m == capacity.length <= 50
 *   • 1 <= apple[i], capacity[i] <= 50
 *   • The input is generated such
 *     that it's possible to redistribute packs of apples into boxes.
 *
 * Hint 1:
 *   Sort array capacity in non-decreasing order.
 *
 * Hint 2:
 *   Greedily select boxes with the largest capacities
 *   to redistribute apples optimally.
 **
 * https://leetcode.com/problems/apple-redistribution-into-boxes/
***/

using System;

namespace Problems;

public class AppleRedistributionIntoBoxes
{
    public int MinimumBoxes( int[] apple, int[] capacity )
    {
        int applesTotal = 0;

        foreach ( int a in apple )
        {
            applesTotal += a;
        }

        Span<int> capMap = stackalloc int[51];

        foreach ( int cap in capacity )
        {
            capMap[cap]++;
        }

        int minBoxes = 0;

        for ( int i = capMap.Length - 1; i > 0; i-- )
        {
            if ( capMap[i] > 0 )
            {
                int min = Math.Min( applesTotal, capMap[i] * i );

                applesTotal -= min;

                minBoxes += (int)Math.Ceiling( 1.0 * min / i );

                if ( applesTotal <= 0 )
                {
                    return minBoxes;
                }
            }
        }

        return minBoxes;
    }
}
