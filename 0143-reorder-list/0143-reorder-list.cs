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
  public void ReorderList(ListNode head)
  {
    if (head == null)
    {
      return;
    }

    var l = new List<ListNode>();
    var c = head;

    while (c != null)
    {
      l.Add(c);
      c = c.next;
    }

    var i = 0;
    var to = (int)Math.Ceiling(l.Count / 2.0);
    c = null;
    
    while (i < to)
    {

      ListNode n1 = l[i];
      ListNode n2 = null; 

      if (l.Count - i - 1 < l.Count)
      {
        n2 = l[l.Count - i - 1];
      }

      if (c != null) {
        c.next = n1;
      }

      n1.next = n2;
      c = n2;
      
      i++;
    }
     
    if (c != null) {
        c.next = null; 
    }
   

    head = l[0];
  }
}