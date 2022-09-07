// Brute Force
public class Solution {
    public string LongestPalindrome(string s) {
        if (s == null) return "";
        if (s.Length == 1) return s;
        string longest = "";
        for (int i = 0; i < s.Length; i++) {
            for (int j = s.Length- i; j > 0; j--) {
                string res = s.Substring(i, j);
                if (IsPalindrome(res) && res.Length > longest.Length)
                    longest = res;
            }
        }
        return longest;
    }
    public bool IsPalindrome (string s) {
        for (int i = 0; i < (s.Length / 2) + 1; i++)
            if (s[i] != s[s.Length - 1 - i]) return false;
        return true;
    }
}