public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int ret = 0;
        int a = nums1.Length;
        int b = nums2.Length;
        int[,] grid = new int[a + 1, b + 1];
        for (int i = a - 1; i >= 0; i--) {
            for (int j = b - 1; j >= 0; j--) {
                if (nums1[i] == nums2[j]) grid[ i , j] = 1 + grid[i + 1, j + 1];
                if (ret < grid[i,j]) ret = grid[ i , j ];
            }
        }
        return ret;
    }
}