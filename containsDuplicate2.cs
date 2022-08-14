public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (i > k) hs.Remove(nums[i - k - 1]);
            if (!hs.Add(nums[i])) return true;
        }
        return false;
    }
}