using System;
using System.Linq;

namespace Assessment1
{
    public class SequenceAnalysis
    {
        public static string Order(string sentence)
        {
            string[] wordArray = sentence.Split(' ');
   
            var upperCaseArray = wordArray.Where(x => x == x.ToUpper() && x.Any(char.IsNumber) == false);
            string upperCaseLetters = string.Join("", upperCaseArray);

            char[] orderedUpperCase = upperCaseLetters.Distinct().ToArray();
            Array.Sort(orderedUpperCase);    

            return new string(orderedUpperCase);            
        }
    }
}
