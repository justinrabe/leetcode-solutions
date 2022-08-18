public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int count = 0;
        HashSet<int> hs = new HashSet<int>();
        
        foreach (int num in nums) {
            if (hs.Contains(num - diff) && hs.Contains(num - diff*2))
                count++;
            hs.Add(num);
        }
        return count;
    }
}