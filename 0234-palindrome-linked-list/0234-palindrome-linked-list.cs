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
  public bool IsPalindrome(ListNode head)
  {
    var c = head;
    var l = new List<int>();
    var s = new Stack<int>();

    while (c != null)
    {
      l.Add(c.val);
      s.Push(c.val);

      c = c.next;
    }


    foreach (var v in l)
    {
      var vs = s.Pop();

      if (vs != v) return false;
    }
    return true;
  }
}