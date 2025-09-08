using DataStructures;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        Invert(root);
        return root;
    }

    private void Invert(TreeNode pointer)
    {
        if (pointer is null) { return; }

        (pointer.left, pointer.right) = (pointer.right, pointer.left);
        InvertTree(pointer.left);
        InvertTree(pointer.right);
    }
}