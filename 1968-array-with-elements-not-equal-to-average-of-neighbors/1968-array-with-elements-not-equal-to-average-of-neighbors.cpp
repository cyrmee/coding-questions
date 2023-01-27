class Solution {
public:
    vector<int> rearrangeArray(vector<int>& nums) {
        int n = nums.size() / 2;
        nth_element(nums.begin(), nums.begin() + n, nums.end());
        int median = nums[n];

        vector<int> result(nums.size(), 0);
        cout << median << endl;

        int odd = 1, even = 0;
        for (int i = 0; i < nums.size(); i++)
        if (nums[i] < median && odd < nums.size()) {
            result[odd] = nums[i];
            odd += 2;
        }
        else if (even < nums.size()) {
            result[even] = nums[i];
            even += 2;
        }
        else result[i] = nums[i];

        return result;
    }
};