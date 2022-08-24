public class Solution {
    TreeNode res, target;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        this.target = target;
        inorder(original, cloned);
        return res;
        
    }
    public void inorder(TreeNode o, TreeNode c) {
        if (o != null) {
            inorder(o.left, c.left);
            if (o == target) res = c;
            inorder(o.right, c.right);
        }
    }
}