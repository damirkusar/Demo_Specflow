namespace Demo_Specflow
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Result { get; private set; }

        public void Add(int a, int b)
        {
            this.Result = a + b;
        }
    }
}
