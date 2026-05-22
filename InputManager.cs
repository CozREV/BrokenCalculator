namespace BrokenCalculator
{
    class InputManager
    {
        public int GetNumber(string text)
        {
            Console.Write(text);

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input");
                return GetNumber(text);
            }

            if (number < 0)
            {
                Console.WriteLine("Negative numbers are not allowed.");
                return GetNumber(text);
            }

            return number;
        }
    }
}
