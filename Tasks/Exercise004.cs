using System;
using System.Collections.Generic;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            try
            {

                string append = "ay";

                List<string> changedWords = new List<string>();

                foreach (string s in str.Split(' '))
                {
                    if (s.Length == 1)
                    {
                        changedWords.Add(changedWords + append);
                    }
                    else
                    {
                        bool containsPunctuationMark = false;

                        for (int i = 0; i < s.Length; i++)
                        {
                            if (char.IsPunctuation(s[i]))
                            {
                                containsPunctuationMark = true;
                                changedWords.Add(s.Substring(1 ,  i - 1) + (string)s.Substring(0 , 1) + append + s.Substring(i));
                                break;
                            }
                        }

                        if (!containsPunctuationMark)
                        {

                            string appendedWord = s.Substring(1, s.Length - 1) + (string)s.Substring(0, 1) + append;                          

                            changedWords.Add(appendedWord);
                        }
                       
                    }

                }
                return string.Join(" ", changedWords);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

