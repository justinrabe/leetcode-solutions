public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int [] alphs = new int[26];
        for (int i = 0; i < magazine.Length; i++) 
            alphs[magazine[i] - 'a']++;      
        for (int i = 0; i < ransomNote.Length; i++)
            if (--alphs[ransomNote[i] - 'a'] < 0) return false;
        return true;
    }
}