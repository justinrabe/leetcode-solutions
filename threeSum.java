class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        Set<List<Integer>> res = new HashSet<>();
        Arrays.sort(nums);
        if (nums.length == 0) return new ArrayList<>(res);
        for (int i = 0; i < nums.length; i++) {
            int x = nums[i];
            int[] p = twoSum(nums, -1 * x, i);
            if (p != null) {
                List<Integer> sum = Arrays.asList(nums[i], nums[p[0]], nums[p[1]]);
                Collections.sort(sum);  
                res.add(sum);
            }
        }
        return new ArrayList<>(res);
    }
    public int[] twoSum(int[] nums, int target, int ignore) {
        HashMap<Integer,Integer> indexMap = new HashMap<Integer,Integer>();
        for(int i = 0; i< nums.length; i++) {
            if (i == ignore) continue;
            int remaining = target - nums[i];
            if (indexMap.containsKey(remaining))
                return new int[]{indexMap.get(remaining), i};
            indexMap.put(nums[i], i);
                
        }
        return null;
    }
}