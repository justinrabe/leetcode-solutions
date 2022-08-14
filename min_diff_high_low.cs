public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if (nums.Length == 1) return 0;
        int minDiff = Int32.MaxValue;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (i + k - 1 >= nums.Length) break;
            minDiff = Math.Min(minDiff, nums[i+k-1] - nums[i]);
        }
        return minDiff;
    }
}