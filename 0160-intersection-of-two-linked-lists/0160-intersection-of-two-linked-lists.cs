public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {

        var n1 = headA;

        while (n1 != null)
        {
            var n2 = headB;
            while (n2 != null)
            {
                if (n1 == n2) return n1;
                n2 = n2.next;
            }
            n1 = n1.next;
        }

        return null;
    }
}