public class Solution {
    public bool IsPalindrome(string s) {
        s = RemoveCharsAndSpaces(s);
        int head = 0;
        int tail = s.Length - 1;
        while (head < tail)
            if (s[head++] != s[tail--]) return false;
        return true;
    }
    
    public string RemoveCharsAndSpaces(string str) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
            if ((str[i] >= 48 && str[i] <= 57)|| (str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                    sb.Append(str[i]);

        return sb.ToString().ToLower();
    }
}