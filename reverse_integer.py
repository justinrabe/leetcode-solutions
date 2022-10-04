class Solution:
    def reverse(self, x: int) -> int:
        ret = 0
        sign = 1
        if x < 0:
            sign = -1
            x = -1 * x
        while x != 0:
            pop = x % 10
            x = int(x / 10)
            ret = ret * 10 + pop
        if ret > (2**31 - 1): return 0
        if ret < (-2**31): return 0
        return ret * sign