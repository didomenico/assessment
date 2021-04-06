using System;
using System.Linq;

namespace Assessment1
{
    public class SequenceAnalysis
    {
        public static string Order(string sentence)
        {
            string[] wordArray = sentence.Split(' ');
   
            var upperCaseWords = wordArray.Where(word => word == word.ToUpper() && 
                                                 word.Any(char.IsNumber) == false); // (condition == false) more readable
                                                                                    // than (!condition) in this case.
            string concatenation = string.Join("", upperCaseWords);

            var distinctSorted = concatenation.Distinct().OrderBy(letter => letter);

            return string.Join("", distinctSorted);
        }
    }
}