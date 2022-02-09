class Solution:
    def plusOne(self, digits):
        str_digits = map(str, digits)
        str_lists = list(str_digits)
        total_int = int((''.join(str_lists)))
        total_int += 1
        print(list(map(int, str(total_int))))



solution = Solution()
print(solution.plusOne([1,2,3]))