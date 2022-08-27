public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        while(s.Count > 0) {
            TreeNode curr = s.Pop();
            res.Insert(0, curr.val);
            if (curr.left != null) s.Push(curr.left);
            if (curr.right != null) s.Push(curr.right);
        }
        return res;
        
    }
}