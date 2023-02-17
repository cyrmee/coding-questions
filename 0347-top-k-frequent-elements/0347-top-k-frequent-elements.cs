public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencyTable = new Dictionary<int, int>();
        var result = new List<int>();

        for (int i = nums.Min(); i <= nums.Max(); i++)
            frequencyTable.Add(i, 0);

        for (int i = 0; i < nums.Length; i++)
            frequencyTable[nums[i]]++;

        var sortedDict = (from entry in frequencyTable orderby entry.Value descending select entry).Take(k);

        foreach(var item in sortedDict)
            result.Add(item.Key);

        return result.ToArray();
    }
}