public class Solution {

  bool found = false;
  public bool IsMatch(string s, string p)
  {
    test(s, "", p, default(char));
    return found;
  }

  public void test(string s, string currentS, string toTest, char prevPattern)
  {
    if (currentS == s && toTest.Length == 0)
    {
      found = true;
      return;
    }

    if (toTest.Length == 0) {
      return;
    }

    var nextPattern = toTest[0];

    if (currentS == s && nextPattern == '*')
    {
      test(s, currentS, removeFirst(toTest), nextPattern);
      return;
    }

    var nextNextPattern = toTest.Length> 1 ? toTest[1] : default(char);

    if (currentS== s && nextNextPattern == '*') {
      test(s, currentS, toTest.Substring(2, toTest.Length -2 ), '*');
    }



    if (currentS == s && toTest.Length > 0)
    {
      return;
    }


    var nextString = s[currentS.Length];

    if (nextPattern == '.')
    {
      test(s, currentS + nextString, removeFirst(toTest), nextPattern);

      if(nextNextPattern == '*') {
        test(s, currentS, toTest.Substring(2, toTest.Length -2 ), '*');
      }

      return;
    }

    if (nextPattern == nextString)
    {
      test(s, currentS + nextString, removeFirst(toTest), nextPattern);

      if(nextNextPattern == '*') {
        test(s, currentS, toTest.Substring(2, toTest.Length -2 ), '*');
      }
      return;
    }

    if (nextPattern == '*')
    {
      test(s, currentS, removeFirst(toTest), nextPattern);
      var previus = currentS.Length == 0? default(char) : currentS[currentS.Length - 1];

      if (previus == nextString || prevPattern =='.' )
      {
        var pPattern = prevPattern == '.' ? prevPattern: previus;
        test(s, currentS + nextString, toTest, pPattern);
        return;
      }
    }


    if (nextNextPattern == '*') {
      test(s, currentS, toTest.Substring(2, toTest.Length -2 ), '*');
    }

 

  }

  public string removeFirst(string c)
  {
    if (c.Length == 0) return c;
    return c.Substring(1, c.Length - 1);
  }
}