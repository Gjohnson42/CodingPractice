using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace CodingPractice
{
    class StringSplitter
    {
        //Implement a function that splits strings by whitespace, returning a string array.
        string[] split;
        public string[] Split 
        {
            get { return split; }
            set { split = value; }
        }
        //Takes in a passed string, splitting up the items by whitespace. Assigns the array to split. 
        public void getWords(string inputString)
        {
            split= inputString.Split(" ");
        }

        //Since the split string is stored in an array, a special function is needed to show it to the user. 
        public void displaySplitToConsole()
        {
            for (int i = 0; i < Split.Length; i++)
            {
                Console.Write(Split[i]);
                //puts in a comma iff the end of the string array hasn't been reached. 
                if (i != Split.Length - 1) 
                {
                    Console.Write(", "); 
                }
            }
        }
    }
}
