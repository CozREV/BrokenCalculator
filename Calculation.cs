namespace BrokenCalculator
{
    class Calculation
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; }
        public int Result { get; set; }

        public Calculation(int number1, int number2, string operation, int result)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
            Result = result;
        }
    }
}
