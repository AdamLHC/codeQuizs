using DataStructures;

public class IsBalancedBTree
{
    public bool IsBalanced(TreeNode root)
    {
        maxDepth(root);
        return isBalancedTree;
    }

    private bool isBalancedTree = true;
    private int maxDepth(TreeNode node)
    {
        if (node == null || !isBalancedTree)
        {
            return 0;
        }

        int leftDepth = maxDepth(node.left);
        int rightDepth = maxDepth(node.right);

        if (Math.Abs(leftDepth - rightDepth) > 1)
        {
            isBalancedTree = false;
            return 0;
        }

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}