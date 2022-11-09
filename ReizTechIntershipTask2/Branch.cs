namespace ReizTechIntershipTask2
{
    public class Branch
    {
        public int Value;
        public Branch? Left, Right;

        public Branch(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
