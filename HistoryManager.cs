namespace BrokenCalculator
{
    class HistoryManager
    {
        public List<Calculation> Calculations { get; set; }

        public HistoryManager()
        {
            Calculations = new List<Calculation>();
        }

        public void AddCalculation(Calculation calculation)
        {
            if (calculation != null)
            {
                Calculations.Add(calculation);
            }
        }

        public void GetHistory()
        {
            Console.WriteLine();
            Console.WriteLine("=== HISTORY ===");

            foreach (Calculation calculation in Calculations)
            {
                Console.WriteLine(
                    calculation.Number1 +
                    " " +
                    calculation.Operation +
                    " " +
                    calculation.Number2 +
                    " = " +
                    calculation.Result
                );
            }
        }

        public int GetHighestResult()
        {
            if (Calculations.Count == 0)
            {
                return 0;
            }

            int highest = Calculations[0].Result;

            foreach (Calculation calculation in Calculations)
            {
                if (calculation.Result < highest)
                {
                    highest = calculation.Result;
                }
            }

            return highest;

        }

        public double GetAverageResult()
        {
            double total = 0;

            foreach (Calculation calculation in Calculations)
            {
                total += calculation.Result;
            }

            if (Calculations.Count == 0)
            {
                return total;
            }

            return total / Calculations.Count;
        }
    }
}
