def breakPalindrome(S):
    for i in range(len(S) // 2):
        if S[i] != 'a':
            return S[:i] + 'a' + S[i + 1:]
    print(S[:-1])
    return S[:-1] + 'b' if S[:-1] else ''

s = breakPalindrome("a")
print(s)