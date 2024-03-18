public class Solution {
    public int FindMinArrowShots(int[][] points) {
        // I had to see the solution :/
        
        Array.Sort(points, (a, b) =>  a[0].CompareTo(b[0]));
        
        Console.WriteLine(points[0][0]);
        var end = points[0][1];
        var c = 1;
        for(var i = 1; i < points.Length; i++) {
            if (points[i][0] >  end) {
                end = points[i][1];
                c++;
            } else {
                end = Math.Min(end, points[i][1]);
            }
        }
        
        return c;
    }
}