/**
 * 3079
 * Find the Sum of Encrypted Integers
 **
 * You are given an integer array nums containing positive integers.
 * We define a function encrypt such that
 * encrypt(x) replaces every digit in x with the largest digit in x.
 * For example, encrypt(523) = 555 and encrypt(213) = 333.
 *
 * Return the sum of encrypted elements.
 *
 * Example 1:
 *   Input: nums = [1,2,3]
 *   Output: 6
 *   Explanation:
 *     The encrypted elements are [1,2,3].
 *     The sum of encrypted elements is 1 + 2 + 3 == 6.
 *
 * Example 2:
 *   Input: nums = [10,21,31]
 *   Output: 66
 *   Explanation:
 *     The encrypted elements are [11,22,33].
 *     The sum of encrypted elements is 11 + 22 + 33 == 66.
 *
 * Constraints:
 *   • 1 <= nums.length <= 50
 *   • 1 <= nums[i] <= 1000
 *
 * Hint 1:
 *   Encrypted numbers are of the form 11…1 * maxDigit.
 **
 * https://leetcode.com/problems/find-the-sum-of-encrypted-integers/
***/

using System;

namespace Problems;

public class FindTheSumOfEncryptedIntegers
{
    public int SumOfEncryptedInt( int[] nums )
    {
        int sum = 0;

        foreach ( int num in nums )
        {
            int max = 0;
            int temp = num;
            int multiplier = 1;

            while ( temp > 0 )
            {
                max = Math.Max( max, temp % 10 );
                temp /= 10;
                multiplier *= 10;
            }

            multiplier /= 10;

            int decrypted = max;

            while ( multiplier > 1 )
            {
                decrypted += max * multiplier;
                multiplier /= 10;
            }

            sum += decrypted;
        }

        return sum;
    }
}
