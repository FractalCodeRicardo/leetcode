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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {

        ListNode a_1 = null;
        ListNode b_1 = null;

        var c = list1;
        var nth = 0;
        while(c != null) {

            if (nth + 1 == a) {
                a_1 = c;
            }

            if (nth == b + 1) {
                b_1 = c;
                break;
            }

            c = c.next;
            nth++;
        }  

        a_1.next = list2;

         c = list2;

        while (c.next != null) c = c.next;

        c.next = b_1;

        return list1;

    }
}