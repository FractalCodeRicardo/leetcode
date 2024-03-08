public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var frec = new Dictionary<int, int>();

        foreach(var n in nums) {
            if(!frec.ContainsKey(n)) {
                frec[n] = 0;
            }

            frec[n]+=1;
        }

        var max = frec.Values.Max();

        var numbers = new List<int>();

        foreach(var n in nums) {
            if (frec[n] == max) {
                numbers.Add(n);
            }
        }

        return numbers.Count;
    }
}