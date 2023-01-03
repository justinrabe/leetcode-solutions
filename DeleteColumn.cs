public class Solution {
    public int MinDeletionSize(string[] strs) {
        //char[][] result = strs.Select(item => item.ToArray()).ToArray();
        string total = String.Join("", strs);
        int l = strs[0].Length;
        char current = total[0];
        int ret = 0;
        for (int i = 0; i < l; i++) {
            for (int j = i; j < total.Length - l; j+= l) {
                if (total[j] > total[j + l]) {
                    ret++;
                    break;
                }
            }
        }

        return ret;
    }
}