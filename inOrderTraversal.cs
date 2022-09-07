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

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> n = new List<int>();
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null || s.Count > 0) {
            while (curr != null) {
                s.Push(curr);
                curr = curr.left;
            }
            curr = s.Pop();
            n.Add(curr.val);
            curr = curr.right;
        }
        return n;
    }
}