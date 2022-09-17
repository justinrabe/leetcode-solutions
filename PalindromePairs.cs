public class Solution {    
    public static Dictionary<int, int> PalindromePairs(string[] words)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 1; j < words.Length; j++)
                {
                    if (words[i] == words[j]) continue;
                    string a = words[i] + words[j];
                    string b = words[j] + words[i];
                    //List<int> aKV = new List<int>{i,j};
                    //List<int> bKV = new List<int>{j,i};
                    if (isPalindrome(a) && !dict.ContainsKey(i))
                        dict.Add(i, j);
                    if (isPalindrome(b) && !dict.ContainsKey(j))
                        dict.Add(j, i);
                }
            }
            return dict;
        }
    public static bool isPalindrome(string word)
        {
            for (int i = 0; i < (word.Length / 2) + 1; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            }
            return true;
        }
}