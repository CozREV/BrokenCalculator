namespace BrokenCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Menu menu = new Menu();

            bool running = true;

            while (running)
            {
                menu.Show();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        calculator.AddNumbers();
                        break;

                    case "2":
                        calculator.SubtractNumbers();
                        break;

                    case "3":
                        calculator.ShowHistory();
                        break;

                    case "4":
                        calculator.ShowHighestResult();
                        break;

                    case "5":
                        calculator.ShowAverageResult();
                        break;

                    case "6":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
