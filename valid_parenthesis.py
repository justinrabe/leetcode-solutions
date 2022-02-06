class Solution:
    def isValid(self, s: str) -> bool:
        parenthesis = {')':'(', 
                       '}':'{',
                       ']':'['}
        stack =[]
        
        if len(s)%2==1:
            print ('odd')
            return False
        for i in s:
            if i in ['(', '{', '[']:
                print('push', i)
                stack.append(i)
            else:
                if stack and stack[-1] == parenthesis[i]:
                    print('pop', i)
                    stack.pop()
                else:
                    print('invalid')
                    return False
        if stack:
            print('invalid')
            return False
        return True
solution = Solution()
print(solution.isValid('()'))