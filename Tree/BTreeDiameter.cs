using DataStructures;

public class BTreeDiameter
{
    private int MaxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        maxDiameter(root);
        return MaxDiameter;
    }

    private int maxDiameter(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftDiameter = maxDiameter(node.left);
        int rightDiameter = maxDiameter(node.right);
        MaxDiameter = Math.Max(MaxDiameter, leftDiameter + rightDiameter);
        return Math.Max(leftDiameter, rightDiameter) + 1;
    }
}