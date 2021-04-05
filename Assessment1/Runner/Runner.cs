using System;
using System.Linq;

namespace Assessment1
{    
    public class Runner
    {
        static readonly Action<string> print = Console.WriteLine;

        static public void Main(String[] args)
        {
            print("=====================================");
            print(" Welcome! Please type a key to chose:");
            print("=====================================");
            print("[F]ind the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.");
            print("[O]rder characters of uppercase words in a sentence alphabetically.");
            print("[E]xit");

            
            bool hasToClearConsole = false;
            string key;
            do
            {
                key = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                if (hasToClearConsole) { clearConsole(2); }

                switch (key.First())
                {
                    case 'F': print(FindSum()); break;
                    case 'O': print(OrderSentence()); break;                    
                }

                hasToClearConsole = (key == "F" || key == "O");
            }
            while (key != "E");
        }

        private static void clearConsole(int lines)
        {  
            Console.SetCursorPosition(0, Console.CursorTop - lines);

            for (int i = 0; i < lines; i++)
            {
                Console.Write(new string(' ', Console.WindowWidth));
            }
                
            Console.SetCursorPosition(0, Console.CursorTop - lines);
        }

        private static string FindSum()
        {
            Console.Write("Type number: ");

            try
            {
                int limit = int.Parse(Console.ReadLine());
                return "Result: " + SumOfMultiples.Until(limit);
            }
            catch(Exception) // Catch-all for Format, ArgumentNull
            {                // and Overflow exceptions.
                clearConsole(1);
                FindSum();
                return null;
            }     
        }

        private static string OrderSentence()
        {
            Console.Write("Type sentence: ");
            string input = Console.ReadLine();

            return "Result: " + SequenceAnalysis.Order(input);            
        }
    }
}
