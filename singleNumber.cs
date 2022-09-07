public class Solution {
    public int SingleNumber(int[] nums) {
        int xor = 0;
        foreach (int i in nums)
            xor ^= i;
        return xor;
    }
}