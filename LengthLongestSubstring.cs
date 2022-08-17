public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new HashSet<char>();
        int max = 0;
        int i = 0;
        int j = 0;
        while (j < s.Length) {
            if (!hs.Contains(s[j])) {
                hs.Add(s[j++]);
                max = Math.Max(max, hs.Count);
            }
            else {
                hs.Remove(s[i++]);
            }
        }
        return max;
    }
}