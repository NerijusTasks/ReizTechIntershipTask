using ReizhTechTask2Update;

Branch branch = new Branch();

branch = branch.NewBranch(0);

branch.child.Add(branch.NewBranch(1));
branch.child.Add(branch.NewBranch(2));

branch.child[0].child.Add(branch.NewBranch(3));

branch.child[1].child.Add(branch.NewBranch(4));
branch.child[1].child.Add(branch.NewBranch(5));
branch.child[1].child.Add(branch.NewBranch(6));

branch.child[1].child[0].child.Add(branch.NewBranch(7));
branch.child[1].child[1].child.Add(branch.NewBranch(8));
branch.child[1].child[1].child.Add(branch.NewBranch(9));

branch.child[1].child[1].child[0].child.Add(branch.NewBranch(10));

Console.WriteLine($"Structure depth is: {branch.DepthOfStructure(branch)}");