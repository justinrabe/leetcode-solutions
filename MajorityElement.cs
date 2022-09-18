public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length/2];
    }
    public int MajorityElement(int[] nums) {
        int candidate = nums[0];
        int counter = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == candidate) counter++;
            else {
                counter--;
                if (counter < 0) {
                    candidate = nums[i];
                    counter = 1;
                }
            }
        }
        return candidate;
    }
}
