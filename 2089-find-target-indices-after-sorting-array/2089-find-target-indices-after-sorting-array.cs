public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        var targetIndices = new List<int>();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == target) 
                targetIndices.Add(i);
        return targetIndices;
    }
}