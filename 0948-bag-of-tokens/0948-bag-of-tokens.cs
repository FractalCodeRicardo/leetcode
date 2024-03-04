public class Solution
{

    public int BagOfTokensScore(int[] tokens, int power)
    {
        var max = 0;
        var l = 0;
        var r = tokens.Length -1;
        var s = 0;
        Array.Sort(tokens);
        while(l<=r) {
            if (power>= tokens[l]) {
                power = power - tokens[l];
                l++;
                s++;

                if (max < s) {
                    max = s;
                }

            } else if (s >0) {
                power = power + tokens[r];
                r--;
                s--;
            } else {
                break;
            }

        
        } 

        return max;
    }


}