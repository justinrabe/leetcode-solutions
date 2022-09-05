public class Solution {
    public int MySqrt(int x) {
        int low = 1;
        int high = x;
        if (x == 0) return 0;
        if (x == 1) return 1;
        while (true) {
            int mid = low + (high - low) / 2;
            if (mid > x / mid) high = mid - 1;
            else {
                if (mid + 1 > x/(mid + 1)) return mid;
                low = mid + 1;
            }
        }
        return 0;
    }
}