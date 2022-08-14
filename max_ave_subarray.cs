public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxAveVal = 0;
        if (nums.Length == 1) return (double)nums[0];
        if (nums.Length == k) return (double)nums.Average();
        for (int i = 0; i <= nums.Length - k; i++) {
            var subArray = new ArraySegment<int>(nums, i, k);
            double aveVal = (double) subArray.Sum() / k;
            if (aveVal > maxAveVal) maxAveVal = aveVal;
        }
        return maxAveVal;
    }
}