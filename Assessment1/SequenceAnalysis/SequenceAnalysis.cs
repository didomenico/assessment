using System;
using System.Linq;

namespace Assessment1
{
    public class SequenceAnalysis
    {
        public static string Order(string sentence)
        {
            string[] wordArray = sentence.Split(' ');
   
            var upperCaseWords = wordArray.Where(x => x == x.ToUpper() && 
                                                 x.Any(char.IsNumber) == false);
            
            string concatenation = string.Join("", upperCaseWords);

            var distinctSorted = concatenation.Distinct().OrderBy(letter => letter);

            return string.Join("", distinctSorted);
        }
    }
}
