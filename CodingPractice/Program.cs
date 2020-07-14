//The purpose of this program is to practice the common things you'll use for a coding assessment. 
// 1. String manipulation, 2. Array traversal, 3. Class instantiation, 4. Recursion, 5. Control flow
using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object to split a string and store its value. 
            StringSplitter stringSplitter = new StringSplitter();
            string testString = "The quick brown fox jumped over the lazy dog.";
            stringSplitter.getWords(testString);

            //Display all of the seperate words in the Split array.
            stringSplitter.displaySplitToConsole();
        }
    }
    
}
