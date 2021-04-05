using System;
using System.Linq;

namespace Assessment1
{
    public class SequenceAnalysis
    {
        public static string Order(string sentence)
        {
            string[] wordArray = sentence.Split(' ');
            string upperCaseLetters = "";

            foreach(string word in wordArray)
            {
                if (word == word.ToUpper() &&
                    word.Any(char.IsNumber) == false) 
                {
                    upperCaseLetters += word; 
                }
            }

            char[] orderedUpperCase = upperCaseLetters.Distinct().ToArray();
            Array.Sort(orderedUpperCase);
            
            return new string(orderedUpperCase);
        }
    }
}
