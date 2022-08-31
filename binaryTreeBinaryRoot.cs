public class Solution {
    int total = 0;
    public int SumRootToLeaf(TreeNode root) {
        traverse(root, 0);
        return total;
    }
    
    public void traverse(TreeNode root, int num) {
        if (root != null) {
            num = (num << 1) | root.val;
            if (root.left == null && root.right == null)  total += num;
            traverse(root.left, num);
            traverse(root.right, num);
        }
    }
}