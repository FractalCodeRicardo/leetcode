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
    public ListNode MiddleNode(ListNode head) {
        if (head== null) return null; 
        int size = 0;

        var thead =head;
        while(thead != null) {
            thead = thead.next;
            size++;
        }

        var middle = (int)Math.Floor(size/2.0);

        thead =head;
        var i = 0;
        while(thead != null) {

            if (i == middle) return thead;

            thead = thead.next;
            i++;
        }

        return null;
    }
}