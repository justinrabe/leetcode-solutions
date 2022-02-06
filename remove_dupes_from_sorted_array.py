class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        p = 1
        for value in nums:
            if value != nums[p-1]:
                nums[p] = value
                p+=1
        return p 