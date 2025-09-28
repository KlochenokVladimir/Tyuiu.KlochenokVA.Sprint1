using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        { 
            string[] words = value.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
  
            string result = "";

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    result += word[word.Length - 1];
                }
            }

            return result;
        }
    }
}
