using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                bool isUpper = ( word == word.ToUpper() );

                if (isUpper) { upperCaseLetters += word; }
            }

            char[] orderedUpperCase = upperCaseLetters.ToArray();
            Array.Sort(orderedUpperCase);           

            return new string(orderedUpperCase.Distinct().ToArray());
        }
    }
}
