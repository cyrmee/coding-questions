public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var result = 0;
        var dictionary = new Dictionary<int, int>(nums.Max());

        for (int i = 0; i < nums.Length; i++)
        {
            if(dictionary.ContainsKey(nums[i]))
                dictionary[nums[i]]++;
            else
            {
                dictionary.Add(nums[i], 0);
                dictionary[nums[i]]++;
            }
        }

        foreach (var item in dictionary)
            result += item.Value * (item.Value - 1) / 2;

        return result;
    }
}