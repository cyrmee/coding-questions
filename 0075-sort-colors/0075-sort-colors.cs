public class Solution {
    public void SortColors(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[minPosition])
                    minPosition = j;
            }
            (nums[minPosition], nums[i]) = (nums[i], nums[minPosition]);
        }
    }
}