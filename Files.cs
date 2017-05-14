using System;
using System.IO;

namespace MoshSolutions
{
    public class Files
    {
		
		/* 1- Write a program that reads a text file and displays the number of words as well as the longest word.*/
		
        public void Exercise1()
        {
            var path = @"E:\secret.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine("Words counter: {0}", content.Split(' ').Length);
            var longest = 0;
            var longestWord = "";
            for(var i = 0; i < content.Split(' ').Length-1; i++)
            {
                if(content.Split(' ')[i].Length > content.Split(' ')[i+1].Length)
                {
                    longest = content.Split(' ')[i].Length;
                    longestWord = content.Split(' ')[i];
                }
            }
            Console.WriteLine("Longest word in the text is: {0}", longestWord);
        }
    }
}
    

