/**
 * 1290
 * Convert Binary Number in a Linked List to Integer
 **
 * Given head which is a reference node to a singly-linked list.
 * The value of each node in the linked list is either 0 or 1.
 * The linked list holds the binary representation of a number.
 *
 * Return the decimal value of the number in the linked list.
 *
 * The most significant bit is at the head of the linked list.
 *
 * Example 1:
 *   Input: head = [1,0,1]
 *   Output: 5
 *   Explanation:
 *     (101) in base 2 = (5) in base 10
 *
 * Example 2:
 *   Input: head = [0]
 *   Output: 0
 *
 * Constraints:
 *   • The Linked List is not empty.
 *   • Number of nodes will not exceed 30.
 *   • Each node's value is either 0 or 1.
 *
 * Hint 1:
 *   Traverse the linked list and store all values in a string or array.
 *   convert the values obtained to decimal value.
 *
 * Hint 2:
 *   You can solve the problem in O(1) memory using bits operation.
 *   use shift left operation ( << ) and or operation ( | )
 *   to get the decimal value in one operation.
 **
 * https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
***/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
***/

namespace Problems;

public class ConvertBinaryNumberInALinkedListToInteger
{
    public int GetDecimalValue( ListNode head )
    {
        int result = 0;

        while ( head is not null )
        {
            result = ( result << 1 ) + head.val;
            head = head.next;
        }

        return result;
    }
}
