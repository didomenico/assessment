using System;
using System.Linq;

namespace Assessment1
{
    public class SequenceAnalysis
    {
        public static string Order(string sentence)
        {
            if (sentence == null || sentence == "") { return ""; }

            string[] wordArray = sentence.Split(' ');   
            var upperCaseArray = wordArray.Where(word => word == word.ToUpper() &&
                                                 word.Any(char.IsNumber) == false);
            var upperCaseDistinct = string.Join("", upperCaseArray).Distinct();

            var sorted = upperCaseDistinct.OrderBy(letter => letter);

            return string.Join("", sorted);
        }
    }
}