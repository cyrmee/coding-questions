public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        var sumsList = new List<int>(); 

        for (int i = 0; i < nums.Length / 2; i++)
            sumsList.Add(nums[i] + nums[nums.Length - 1 - i]);
        
        return sumsList.Max();
    }
}