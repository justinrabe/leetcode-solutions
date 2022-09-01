public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return BinarySearch(nums, 0, nums.Length - 1);
    }
    
    public TreeNode BinarySearch(int[] nums, int left, int right) {
        if (left > right) return null;
        int mid = (left + right) / 2;
        TreeNode t = new TreeNode (nums[mid]);
        t.left = BinarySearch(nums, left, mid - 1);
        t.right = BinarySearch(nums, mid + 1, right);
        return t;
    }
}