/**
 * 203
 * Remove Linked List Elements
 **
 * Given the head of a linked list and an integer val,
 * remove all the nodes of the linked list
 * that has Node.val == val,
 * and return the new head.
 *
 * Example 1:
 *   Input: head = [1,2,6,3,4,5,6], val = 6
 *   Output: [1,2,3,4,5]
 *
 * Example 2:
 *   Input: head = [], val = 1
 *   Output: []
 *
 * Example 3:
 *   Input: head = [7,7,7,7], val = 7
 *   Output: []
 *
 * Constraints:
 *   • The number of nodes in the list is in the range [0, 104].
 *   • 1 <= Node.val <= 50
 *   • 0 <= val <= 50
 **
 * https://leetcode.com/problems/remove-linked-list-elements/
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

public class RemoveLinkedListElements
{
    public ListNode RemoveElements( ListNode head, int val )
    {
        if ( head is null )
        {
            return head;
        }

        head.next = RemoveElements( head.next, val );

        return head.val == val ? head.next : head;
    }
}
