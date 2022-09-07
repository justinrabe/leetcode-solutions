public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        return Math.Abs(depth(root.left) - depth(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int depth(TreeNode root) {
        if (root == null) return 0;
        return Math.Max(depth(root.left), depth(root.right)) + 1;
    }
}