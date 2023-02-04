public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        var numsList = new LinkedList<int>(nums);
        int i = 0, j = nums.Length - 1, count = 0;
        while(i < j)
        {
            if (nums[i] + nums[j] == k)
            {
                count += 1;
                i += 1;
                j -= 1;
            }
            else if (nums[i] + nums[j] < k)
                i += 1;
            else
                j -= 1;
        }
        return count;
    }
}