public class Solution {
    
    public bool BuddyStrings(string s, string goal) {
        //double pointers

        int i = 0;
        int j = s.Length - 1;

        if (s.Equals(goal)) {
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s) {
                set.Add(c);
            }
            return set.Count < goal.Length;
        }
        while (i < j && s[i] == goal[i]) {
            i++;
        }
        while (j >= 0 && s[j] == goal[j]) {
            j--;
        }
        char[] tempS = s.ToCharArray();
        if (i < j ) {

            char temp = s[i];
            tempS[i] = tempS[j];
            tempS[j] = temp;
        }
        return string.Join("", tempS).Equals(goal);

    }
}