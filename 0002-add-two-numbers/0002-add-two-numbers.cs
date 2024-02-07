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
    
  
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var sum1 = reverse(l1);
        var sum2 = reverse(l2);
        var total = sumStrings(sum1, sum2);
        Console.WriteLine(total);
        var root = new ListNode(int.Parse(total[total.Length - 1].ToString()));
        var init = root;
        for (int i = total.Length - 2; i >= 0; i--)
        {
            var digit = int.Parse(total[i].ToString());
            var next = new ListNode(digit);
            root.next = next;
            root = next;
        }

        return init;
    }

    public string reverse(ListNode l)
    {
        String total = "";

        ListNode cursor = l;
        while (cursor != null)
        {
            total = cursor.val + total;
            cursor = cursor.next;
        }

        return total;
    }

    public string repeat(string cad, int times)
    {
        var output = "";
        for (int i = 0; i < times; i++)
        {
            output = output + cad;
        }

        return output;
    }

    public string sumStrings(string num1, string num2)
    {
        int max = Math.Max(num1.Length, num2.Length);
        int min = Math.Min(num1.Length, num2.Length);
        string leadingZeros = repeat("0", max - min);

        if (num1.Length > num2.Length)
        {
            num2 = leadingZeros + num2;
        }
        else
        {
            num1 = leadingZeros + num1;
        }

        int res = 0;

        string output = "";

        for (int i = max - 1; i >= 0; i--)
        {
            int n1 = int.Parse(num1[i].ToString());
            int n2 = int.Parse(num2[i].ToString());

            int total = n1 + n2 + res;

            if (total >= 10)
            {
                output = total.ToString()[1].ToString() + output;
                res = 1;
            } else {
                res = 0;
                output = total.ToString() + output;
            }

        }

        if (res != 0)
        {
            output = res + output;
        }

        return output;

    }

}