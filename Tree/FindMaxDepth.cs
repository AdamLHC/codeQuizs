using DataStructures;

namespace Tree;

public class FindMaxDepth
{
    public int MaxDepth(TreeNode root)
    {
        return WalkDepth(root);
    }

    private int WalkDepth(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftDepth = WalkDepth(node.left) + 1;
        int rightDepth = WalkDepth(node.right) + 1;
        return Math.Max(leftDepth, rightDepth);
    }
}