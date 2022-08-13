public class Solution {
    public int CountGoodSubstrings(string s) {
        int count = 0;
        for (int i = 0; i < s.Length - 2; i++)
            if (isASet(s.Substring(i, 3))) count++; 
        return count;
    }
    public bool isASet (string s) {
        HashSet<char> hs = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
            hs.Add(s[i]);
        return hs.Count == 3;
    }
}