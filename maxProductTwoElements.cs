public class Solution {
    public int MaxProduct(int[] nums) {
        int max1 = 0;
        int max2 = 0;
        foreach (int n in nums) {
            if (n > max1) {
                max2 = max1;
                max1 = n;
            } 
            else if (n > max2) {
                max2 = n;
            } 
        }
        return (max1-1)* (max2-1);
    }
}