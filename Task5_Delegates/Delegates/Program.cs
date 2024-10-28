namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            Task3();
            Task4();
            Task6();
            Task7();
            RemoveEven();

            Task5_Input();
        }

        private static void Task3()
        {
            Calc.FuncDelegate<float> factorialDelegate = Calc.Factorial;
            Calc.FuncDelegate<float> numSumDelegate = Calc.NumSum;
            Calc.FuncDelegate<float> numMultDelegate = Calc.NumMult;
            Calc.ActionDelegate<float> printNumSumPrintDelegate = Calc.PrintNumSum;
            Calc.ActionDelegate<float> printNumMultDelegate = Calc.PrintNumMult;

            Console.WriteLine(factorialDelegate(3.82f));
            Console.WriteLine(numSumDelegate(3.82f));
            Console.WriteLine(numMultDelegate(3.82f));
            printNumSumPrintDelegate(3.82f);
            printNumMultDelegate(3.82f);

            Console.WriteLine("-----");
        }

        private static void Task4()
        {
            Calc.FuncDelegate<float> numSumAndMultDelegate = Calc.NumSum;
            numSumAndMultDelegate += Calc.NumMult;

            Console.WriteLine(numSumAndMultDelegate(3.82f));

            Console.WriteLine("-----");
        }

        private static void Task5_Input()
        {
            Calc.ActionDelegate<int>? actions = null;

            Console.WriteLine("Input mode enabled");

            string sumName = nameof(Calc.PrintNumSum);
            string multName = nameof(Calc.PrintNumMult);

            string addName = "Add";
            string removeName = "Remove";

            string executeName = "Execute";
            string quitName = "Quit";

            string? input = null;
            while (input != quitName)
            {
                Console.WriteLine();
                Console.WriteLine($"Type {sumName} to add or remove action");
                Console.WriteLine($"Type {multName} to add or remove action");

                Console.WriteLine($"Type {executeName} to execute actions");
                Console.WriteLine($"Type {quitName} to quit");

                input = Console.ReadLine();
                Calc.ActionDelegate<int>? selectedAction = null;

                if (input == executeName)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Type integer");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int inputInt))
                    {
                        actions?.Invoke(inputInt);
                    }
                }
                else if (input == sumName)
                {
                    selectedAction = Calc.PrintNumSum;
                    Console.WriteLine($"Selected {sumName}");
                }
                else if (input == multName)
                {
                    selectedAction = Calc.PrintNumMult;
                    Console.WriteLine($"Selected {multName}");
                }

                if (selectedAction != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Type {addName} to add action");
                    Console.WriteLine($"Type {removeName} to remove action");

                    input = Console.ReadLine();

                    if (input == addName)
                    {
                        actions += selectedAction;
                        Console.WriteLine($"Added to actions");
                    }
                    else if (input == removeName)
                    {
                        actions -= selectedAction;
                        Console.WriteLine($"Removed from actions");
                    }
                }
            }

            Console.WriteLine("-----");
        }

        private static void Task6()
        {
            var del = Calc.GetEventSumOddMultDelegateInt();
            Console.WriteLine(del(82));
            Console.WriteLine(del(55));
            Console.WriteLine("-----");
        }

        private static void Task7()
        {
            Calc.FuncDelegate<int> numSumDelegate = Calc.NumSum;
            Calc.FuncDelegate<int> numMultDelegate = Calc.NumMult;
            Console.WriteLine(numSumDelegate(13));
            Console.WriteLine(numMultDelegate(13));
            Console.WriteLine("-----");
        }

        private static void RemoveEven()
        {
            int res = 123456789;
            Calc.RemoveEven(ref res, out int removedCount);
            Console.WriteLine(res);
            Console.WriteLine(removedCount);
            Console.WriteLine("-----");
        }
    }
}
