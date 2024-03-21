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
    public ListNode ReverseList(ListNode head) {
        
        if (head == null) return null;

        var c = head;
        var s = new Stack<ListNode>();

        while (c != null) {
            s.Push(c);
            c = c.next;
        }
        
        var f = s.Pop();
        var n = f;
        while (s.Count > 0) {
            n.next = s.Pop();
            n = n.next;
        }
        
        n.next = null;

        return f;
        
    }
}