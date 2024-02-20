public class Solution {

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var output = new List<IList<string>>();

        foreach (var str in strs) {
            var missed = true;

            foreach(var l in output) {

                if (belongs(l, str)) {
                    l.Add(str);
                    missed = false;
                }
            }

            if (missed) {
                var nl =new List<string>();
                nl.Add(str);
                output.Add(nl);
            }

        }

        return output;
    }

    public bool belongs(IList<string> l, string w) {
        if (l.Count == 0) return false;
        return isAnagram(l[0], w);
    }
    

    public bool isAnagram(string w1, string w2) {
        if (w1.Length != w2.Length) return false;

        var ws1 = sort(w1);
        var ws2= sort(w2);

        for (int i = 0; i < ws1.Length; i++)
        {
           if (ws1[i] != ws2[i]) return false; 

        }
        return true;
    }

    public string sort(string w) {
        var c = w.ToCharArray();
        Array.Sort(c);
        return new string(c);
    }
}