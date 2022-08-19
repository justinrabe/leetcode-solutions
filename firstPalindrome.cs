public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (string word in words) 
            if(isPalindrome(word)) return word;
        return "";
        
    }
    
    public bool isPalindrome (string word) {
        for(int i = 0; i < (word.Length / 2) + 1; i++) {
            if (word[i] != word[word.Length - 1 - i])
                return false;
        }
        return true;
    }
}