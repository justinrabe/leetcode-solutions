class Solution:
    def searchRange(self, nums: List[int], target: int) -> List[int]:
        
        def binary_search_low(arr, x):
            low = 0
            high = len(arr) - 1
            mid = 0
            while low <= high:
                mid = (high + low) // 2
                if arr[mid] < x:
                    low = mid + 1
                else:
                    high = mid - 1
            return low

        def binary_search_high(arr,x):
            low = 0
            high = len(arr) - 1
            mid = 0
            while low <= high:
                mid = (high + low) // 2
                if arr[mid] <= x:
                    low = mid + 1
                else: 
                    high = mid - 1
            return high
        
        left = binary_search_low(nums, target)
        right = binary_search_high(nums, target)
        if left <= right: return (left, right)
        return [-1,-1]