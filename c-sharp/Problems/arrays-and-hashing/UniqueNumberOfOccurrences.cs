/**
 * 1207
 * Unique Number of Occurrences
 **
 * Given an array of integers arr,
 * return true if the number of occurrences of each value in the array is unique or
 * false otherwise.
 *
 * Example 1:
 *   Input: arr = [1,2,2,1,1,3]
 *   Output: true
 *   Explanation:
 *     The value 1 has 3 occurrences, 2 has 2 and 3 has 1.
 *     No two values have the same number of occurrences.
 *
 * Example 2:
 *   Input: arr = [1,2]
 *   Output: false
 *
 * Example 3:
 *   Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
 *   Output: true
 *
 * Constraints:
 *   • 1 <= arr.length <= 1000
 *   • -1000 <= arr[i] <= 1000
 *
 * Hint 1:
 *   Find the number of occurrences of each element in the array using a hash map.
 *
 * Hint 2:
 *   Iterate through the hash map and check if there is a repeated value.
 **
 * https://leetcode.com/problems/unique-number-of-occurrences/
***/

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Problems;

public class UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences( int[] arr )
    {
        Dictionary<int, int> countMap = [];

        foreach ( int num in arr )
        {
            ref int count = ref CollectionsMarshal.GetValueRefOrAddDefault( countMap, num, out bool _ );

            count++;
        }

        HashSet<int> freqSet = new( countMap.Count );

        foreach ( int count in countMap.Values )
        {
            if ( !freqSet.Add( count ) )
            {
                return false;
            }
        }

        return true;
    }
}
