public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder();
        int shortest = smallest(strs).Length;
        for(int i = 0; i < shortest; i++) {
            char curr = strs[0][i];
            foreach (string s in strs) {
                if (s[i] != curr) {
                    return sb.ToString();
                }
            }
            sb.Append(curr);
            
        }
        return sb.ToString();
    }
    
    public static string smallest (string[] strs) {
        if (strs == null || strs.Length == 0 ) 
            return "";
        string smallest = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            if (strs[i].Length < smallest.Length) 
                smallest = strs[i];
        }
        return smallest;
    }
}