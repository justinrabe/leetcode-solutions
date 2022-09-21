public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        List<int> ret = new List<int>();
        foreach (int[] i in queries) {
            nums[i[1]] += i[0];
            ret.Add(AddEvenNumbers(nums));
        }
        return ret.ToArray();
    }
    
    public int AddEvenNumbers(int [] nums) {
        int even = 0;
        foreach(var num in nums) 
            if ((num & 1) == 0) even += num;
        return even;
    }
}