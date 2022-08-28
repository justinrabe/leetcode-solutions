    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> l = new List<int>();
        if (root == null) return l;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        while (s.Count > 0) {
            TreeNode curr = s.Pop();
            if (curr != null) {
                l.Add(curr.val);
                s.Push(curr.right);
                s.Push(curr.left);
            }
        }
        return l;
    }
}