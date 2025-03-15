/**
 * 1287
 * Element Appearing More Than 25% In Sorted Array
 **
 * Given an integer array sorted in non-decreasing order,
 * there is exactly one integer in the array
 * that occurs more than 25% of the time,
 * return that integer.
 *
 * Example 1:
 *   Input: arr = [1,2,2,6,6,6,6,7,10]
 *   Output: 6
 *
 * Example 2:
 *   Input: arr = [1,1]
 *   Output: 1
 *
 * Constraints:
 *   • 1 <= arr.length <= 10^4
 *   • 0 <= arr[i] <= 10^5
 *
 * Hint 1:
 *   Divide the array in four parts
 *   [1 - 25%] [25 - 50 %] [50 - 75 %] [75% - 100%]
 * 
 * Hint 2:
 *   The answer should be in one of the ends of the intervals.
 * 
 * Hint 3:
 *   In order to check which is element is the answer
 *   we can count the frequency with binarySearch.
 **
 * https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
***/

namespace Problems;

public class ElementAppearingMoreThan25PercentInSortedArray
{
    public int FindSpecialInteger( int[] arr )
    {
        // 25% boundary
        int threshold = arr.Length / 4;

        for ( int i = 0; i < arr.Length; i++ )
        {
            int right = i + 1;

            while ( right < arr.Length && arr[right] == arr[i] )
            {
                right++;
            }

            if ( ( right - i ) > threshold )
            {
                return arr[i];
            }

            i = right - 1;
        }

        return 0;
    }
}
