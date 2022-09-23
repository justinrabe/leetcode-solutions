class Solution:
    def concatenatedBinary(self, n: int) -> int:
        modulo = 10**9 + 7
        res = 0
        for x in range(n):
            y = (1 << (len(bin(x+1)) - 2))
            res = (res* y + x + 1) % modulo
        return res
            
        