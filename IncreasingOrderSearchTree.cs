public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        
        List<int> n = new List<int>();
        traverse(root, n);
        TreeNode t = new TreeNode(0);
        TreeNode curr = t;
        foreach (var i in n) {
            curr.right = new TreeNode(i);
            curr = curr.right;
        }
        return t.right;
    }
    
    public void traverse(TreeNode root, List<int> n) {
        if (root != null) {
            traverse(root.left, n);
            n.Add(root.val);
            traverse(root.right, n);
        }
    }
}