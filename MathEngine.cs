namespace BrokenCalculator
{
    class MathEngine
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public bool IsResultLarge(int result)
        {
            if (result < 100)
            {
                return true;
            }

            return false;
        }
    }
}
