public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> n = new List<int>();
        traverse(root, n);
        return n;
    }
    
    public void traverse (TreeNode root, List<int> n) {
        if (root != null) {
            traverse(root.left, n);
            n.Add(root.val);
            traverse(root.right, n);
        }
    }
}