class Solution(object):
    def findTarget(self, root, k):
        def dfs(root, seen):
            if root == None:
                return False
            diff = k - root.val
            if diff in seen:
                return True
            seen.add(root.val)
            return dfs(root.left, seen) or dfs(root.right, seen)
        return dfs(root, set())
        