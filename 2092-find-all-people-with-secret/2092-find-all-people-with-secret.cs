public class Solution {

    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        var times = new HashSet<int>();
        var peopleAtTime = new Dictionary<int, List<int[]>>();
        var peopleWhoKnow = new HashSet<int>();

        peopleWhoKnow.Add(0);
        peopleWhoKnow.Add(firstPerson);

        for (int i = 0; i < meetings.Length; i++)
        {
            var m = meetings[i];
            var time = m[2];

            times.Add(time);

            if (!peopleAtTime.ContainsKey(time))
            {
                peopleAtTime.Add(time, []);
            }

            peopleAtTime[time].Add(m);

        }

        var ordererTime = times.Order();

        foreach (var t in ordererTime)
        {
            if (peopleAtTime.ContainsKey(t))
            {
                var found = true;

                while(found) {
                    found = false;
                    foreach (var m in peopleAtTime[t])
                    {
                        var p1 = m[0];
                        var p2 = m[1];

                        if (peopleWhoKnow.Contains(p1) && !peopleWhoKnow.Contains(p2))
                        {
                            peopleWhoKnow.Add(p2);
                            found = true;
                        }

                        if (peopleWhoKnow.Contains(p2) && !peopleWhoKnow.Contains(p1))
                        {
                            peopleWhoKnow.Add(p1);
                            found = true;
                        }

                    }
                }

            }
        }

        return peopleWhoKnow.Order().ToList();

    }


}