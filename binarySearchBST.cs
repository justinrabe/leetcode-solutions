public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        TreeNode curr = root;
        while (curr != null) {
            if (curr.val == val) return curr;
            curr = curr.val > val ? curr.left : curr.right;
        }
        return curr;
    }
}