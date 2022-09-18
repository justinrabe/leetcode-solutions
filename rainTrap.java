class Solution {
    public int trap(int[] height) {
        int l = 0;
        int r = height.length - 1;
        int ret = 0;
        int l_max = 0;
        int r_max = 0;
        while (l < r) {
            if (height[l] < height[r]) {
                if (height[l] >= l_max) l_max = height[l];
                else ret += (l_max - height[l]);
                l++;
            }
            else {
                if (height[r] >= r_max) r_max = height[r];
                else ret += (r_max - height[r]);
                r--;
            }
        }
        
        return ret;
    }
}