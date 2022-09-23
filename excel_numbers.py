class Solution:
    def titleToNumber(self, columnTitle: str) -> int:
        ret = 0
        pos = 0
        for letter in reversed(columnTitle):
            dig = ord(letter) - 64
            ret = ret + dig * 26**pos
            pos += 1
            
        return ret
        