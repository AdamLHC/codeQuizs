using DataStructures;

public class LowestCommonAncestors
{
    public TreeNode solve(TreeNode root, TreeNode p, TreeNode q)
    {
        (int max, int min) = (p.val, q.val);
        if (min > max)
        {
            (max, min) = (min, max);
        }

        if (max < root.val)
        {
            return solve(root.left, p, q);
        }
        if (min > root.val)
        {
            return solve(root.right, p, q);
        }

        return root;
    }


}