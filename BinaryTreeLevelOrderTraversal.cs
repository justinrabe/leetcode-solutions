public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Any()) {
            List <int> level = new List<int>();
            int qCount = q.Count;
            for (int i = 0; i < qCount; i++) {
                TreeNode n = q.Dequeue();
                level.Add(n.val);
                if (n.left != null) q.Enqueue(n.left);
                if (n.right != null) q.Enqueue(n.right);
            }
            res.Add(level);
        }
        return res;
    }
}