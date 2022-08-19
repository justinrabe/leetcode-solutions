public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        List<string> reversed = new List<string>();
        foreach (string word in words)
            reversed.Add(ReverseWord(word));
        return String.Join(" ", reversed.ToArray());
       
    }
    public string ReverseWord (string s) {
        int length = s.Length - 1;
        char[] reverse = new char[s.Length];
        s.ToCharArray().ToList().ForEach(x => {reverse[length--] = x; });
        return new string(reverse);
        
    }
}