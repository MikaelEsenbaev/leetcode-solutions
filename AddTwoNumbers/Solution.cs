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
 */

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode current = result;
        int carryOver = 0;
        while (l1 != null)
        {
            int addition = carryOver + l1.val + l2.val;
            carryOver = 0;
            if (addition > 9)
            {
                addition = addition - 10;
                carryOver = 1;
            }



            current.val = addition;
            current = current.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        return result;

    }
}
