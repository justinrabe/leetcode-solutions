public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;
        int prev = 1;
        int curr = 2;
        int holder = 0;
        for (int i = 3; i <= n; i++) {
            holder = curr;
            curr = prev + curr;
            prev = holder;
        }
        return curr;
    }
}