using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Runner
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Welcome! Please type a key to chose:");
            Console.WriteLine("[F]ind the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.");
            Console.WriteLine("[O]rder characters of uppercase words in a sentence alphabetically.");
            Console.WriteLine("[E]xit");

            string key;
            bool hasWrittenResult = false;

            do
            {
                key = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                if (hasWrittenResult) { clearConsole(2); }

                switch (key.First())
                {
                    case 'F': FindSum(); break;
                    case 'O': OrderSentence(); break;                 
                }

                hasWrittenResult = (key == "F" || key == "O");
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

        private static void FindSum()
        {
            Console.Write("Type number: ");

            try
            {
                int limit = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + SumOfMultiple.Find(limit));
            }
            catch(Exception) // Catch-all for Format, ArgumentNull
            {                // and Overflow exceptions.
                clearConsole(1);
                FindSum();
            }                  
        }

        private static void OrderSentence()
        {
            Console.Write("Type sentence: ");
            string input = Console.ReadLine();

            Console.WriteLine("Result: " + SequenceAnalysis.Order(input));            
        }
    }
}
