
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        if (head == null) return head;
        if (head.next == null && n == 1) return null;

        var cn = head;
        var c = 0;
        while(cn != null) {
            cn = cn.next;
            c++;
        }
        
        if (c == n) {
            return head.next;
        }

        var size = c;
        cn = head;
        c = 0;
        
        while(size - c  -1 != n){
            cn = cn.next;
            c++;
        }
        
        if (cn.next != null) {
            cn.next = cn.next.next;
        }
        

        return head;
    }
}