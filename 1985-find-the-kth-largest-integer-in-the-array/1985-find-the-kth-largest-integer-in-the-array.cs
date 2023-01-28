public class Solution {
    public class Comparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x.Length > y.Length) return 1;
            else if (x.Length < y.Length) return -1;
            else return string.Compare(x, y);
        }
    }

    public string KthLargestNumber(string[] nums, int k)
    {
        var listOfNums = new List<string>( nums );
        listOfNums.Sort(new Comparer());
        
        for (int i = 0; i < listOfNums.Count; i++)
            Console.Write(listOfNums[i] + " ");
        Console.WriteLine();
        return listOfNums[listOfNums.Count - k];
    }
}