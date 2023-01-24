public class Solution {
    public class Comparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
            => (y + x).CompareTo(x + y);
    }
    
    public string LargestNumber(int[] nums) {
        var lstnums = new List<string>();
        foreach (var num in nums)
            lstnums.Add(num.ToString());

        lstnums.Sort(new Comparer());

        if (lstnums[0] == "0") return "0";

        var largestNumber = string.Empty;
        foreach (var item in lstnums)
            largestNumber += item;

        return largestNumber;
    }
}