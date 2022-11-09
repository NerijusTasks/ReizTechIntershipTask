namespace ReizTechIntershipTask2
{
    public class BranchTree
    {
        Branch root;

        int MaxDepth(Branch root)
        {
            if (root == null)
                return 0;

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            if (leftDepth > rightDepth)
                return leftDepth + 1;
            else
                return rightDepth + 1;

        }

        public void CreateBranchTree()
        {
            BranchTree tree = new BranchTree();
            tree.root = new Branch(1);
            tree.root.Left = new Branch(2);
            tree.root.Left.Left = new Branch(3);
            tree.root.Right = new Branch(4);
            tree.root.Right.Left = new Branch(5);
            tree.root.Right.Right = new Branch(6);
            tree.root.Right.Right = new Branch(7);
            tree.root.Right.Left.Left = new Branch(8);
            tree.root.Right.Right.Left = new Branch(9);
            tree.root.Right.Right.Right = new Branch(10);
            tree.root.Right.Right.Left.Right = new Branch(11);
            Console.WriteLine("Max Branch depth is : " + tree.MaxDepth(tree.root));

        }
    }
}
