public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        var m = l.Length;
        var subArray = new List<int>();
        var ans = new List<bool>();

        for (int i = 0; i < l.Length; i++)
            ans.Add(false);

        for (int i = 0; i < m; i++)
        {
            for (int j = l[i]; j < r[i] + 1; j++)
            {
                subArray.Add(nums[l[i]++]);
            }

            subArray.Sort();
            var diff = Math.Abs(subArray[1] - subArray[0]);

            if(subArray.Count == 2) ans[i] = true;
            else
                for (int k = 1; k < subArray.Count - 1; k++)
                {
                    if(Math.Abs(subArray[k + 1] - subArray[k]) != diff)
                    {
                        ans[i] = false;
                        break;
                    }
                    else ans[i] = true;
                }

            subArray.Clear();
        }
        return ans;
    }
}