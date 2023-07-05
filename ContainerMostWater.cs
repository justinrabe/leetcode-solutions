public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int MinArea = 0;
        while (l < r ) {
            int shorter = height[r] < height[l] ? height[r] : height[l];
            int area = shorter * (r - l);
            MinArea = area > MinArea ? area : MinArea;
            if (height[r] < height[l]) r -= 1;
            else l+= 1;
        }
        return MinArea;
    }
}