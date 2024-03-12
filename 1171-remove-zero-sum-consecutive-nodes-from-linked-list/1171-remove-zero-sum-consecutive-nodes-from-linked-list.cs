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
public class Solution {
    public ListNode RemoveZeroSumSublists(ListNode head)
    {
        var c = head;
        ListNode prev = null;
        while (c != null)
        {

            var end = UntilZero(c);
            if (end != null)
            {
                if (prev == null)
                {
                    head = end.next;
                }
                else
                {
                    prev.next = end.next;
                }

                c = head;
                continue;
            }

            prev = c;
            c = c.next;

        }

        return head;
    }

    private ListNode UntilZero(ListNode c)
    {
        var sum = 0;
        var end = c;

        while (end != null)
        {
            sum += end.val;

            if (sum == 0) return end;

            end = end.next;
        }

        return null;
    }
}