public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var counter = 0;
        var output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i && nums[j] < nums[i])
                    counter++;
            }
            output[i] = counter;
            counter = 0;
        }
        return output;
    }
}