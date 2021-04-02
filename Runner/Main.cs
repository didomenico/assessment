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

            Console.WriteLine("[F]ind the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.");
            Console.WriteLine("[O]rder characters of uppercase words in a sentence alphabetically.");
            Console.WriteLine("[E]xit");

            string key;            
            do
            {
                key = Console.ReadKey().KeyChar.ToString().ToUpper();
                Console.WriteLine();

                if (key == "F")
                {
                    Console.WriteLine(SumOfMultiple.Find(16));
                }
                else if (key == "O")
                {
                    Console.WriteLine(SequenceAnalysis.Order("ORDER"));
                }
                else if (key != "E")
                {
                    Console.WriteLine("No choice for the [" + key + "] key.");
                    Console.WriteLine("Please type either the [F], [O] or [E] key.");

                    break; 
                }
            }            
            while (key != "E");
        }
    }
}
