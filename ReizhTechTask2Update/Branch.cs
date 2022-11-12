namespace ReizhTechTask2Update
{
    public class Branch
    {
        public int Id;
        public List<Branch> child;

        public Branch NewBranch(int Id)
        {
            Branch branch = new Branch();
            branch.Id = Id;
            branch.child = new List<Branch>();
            return branch;
        }

        public int DepthOfStructure(Branch structure)
        {
            if (structure == null)
            {
                return 0;
            }

            int maxdepth = 0;

            foreach (Branch currentChild in structure.child)
            {
                maxdepth = Math.Max(maxdepth, DepthOfStructure(currentChild));
            }

            return maxdepth + 1;
        }
    }
}
