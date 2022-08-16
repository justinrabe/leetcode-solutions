public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int l = 0;
        int r = 0;
        for (r = 0; r < nums.Length; r ++) {
            if (nums[r] == 0) k--; 
            if (k < 0) {
                if (nums[l] == 0) k++;
                l++;
            }
        }
        return r - l;
    }
}