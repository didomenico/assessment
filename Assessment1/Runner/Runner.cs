using System;
using System.Linq;

namespace Assessment1
{    
    public class Runner
    {        
        static readonly Action<string> println = Console.WriteLine;

        static public void Main(String[] args)
        {
            println("=====================================");
            println(" Welcome! Please type a key to chose:");
            println("=====================================");
            println("[F]ind the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.");
            println("[O]rder characters of uppercase words in a sentence alphabetically.");
            println("[E]xit");
            
            bool hasToClearConsole = false;
            string key;

            do
            {
                key = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                if (hasToClearConsole) { clearConsole(2); }

                switch (key.First())
                {                    
                    case 'F': println("Result: " + FindSum()); break;
                    case 'O': println("Result: " + OrderSentence()); break;
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

        private static int FindSum()
        {
            Console.Write("Type number: ");

            string input = Console.ReadLine();

            if(input != null && input.All(char.IsNumber) == false)
            {
                clearConsole(1);
                return FindSum();
            }

            int limit = int.Parse(input);
            
            return SumOfMultiples.Until(limit);
        }

        private static string OrderSentence()
        {
            Console.Write("Type sentence: ");
            string input = Console.ReadLine();

            return SequenceAnalysis.Order(input);            
        }
    }
}
