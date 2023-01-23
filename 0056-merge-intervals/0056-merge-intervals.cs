public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => Comparer<int>.Default.Compare(a[0], b[0]));
        var merged = new LinkedList<int[]>();
        foreach (var item in intervals)
        {
            if(merged.Count == 0 || merged.Last()[1] < item[0])
                merged.AddLast(item);
            else if (merged.Last()[1] >= item[0])
                merged.Last()[1] = Math.Max(merged.Last()[1], item[1]);
        }
        return merged.ToArray();
    }
}