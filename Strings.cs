using System;
using System.Collections.Generic;

namespace MoshSolutions
{
    public class Strings
    {
		
		/* 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
		Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
		display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
		
        public void Exercise1()
        {
            var numbers = new List<int>();
            Console.WriteLine("Type a hypen separated numbers list");
            var input = Console.ReadLine();
            var numberList = input.Split('-');
            foreach (var i in numberList)
            {
                numbers.Add(Convert.ToInt32(i));
            }
            var isConsecutive = true;
            numbers.Sort();
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i + 1] != numbers[i] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            var result = (isConsecutive) ? "Consecutive" : "Non consecutive";
            Console.WriteLine(result);
	}

		/*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
		     If the user simply presses Enter, without supplying an input, exit immediately;
			 otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. */
        public void Exercise2()
	{
            var numbers = new List<int>();
            Console.WriteLine("Type a hyphen separated numbers list or Enter to exit");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            else
            {
                var numberList = input.Split('-');
                foreach(var i in numberList)
                {
                    numbers.Add(Convert.ToInt32(i));
                }
                numbers.Sort();
                var isDuplicate = false;
                for(var i = 0; i < numbers.Count; i++)
                {
                    if(numbers.LastIndexOf(numbers[i]) != i)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
			}
                var result = (isDuplicate) ? "Duplicate" : "Non duplicate";
                Console.WriteLine(result); 
	}

		/* 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59.
		      If the time is valid, display "Ok"; otherwise, display "Invalid Time".
			  If the user doesn't provide any values, consider it as invalid time. */
			  
	public void Exercise3()
	{
            Console.WriteLine("Type a time input");
            var input = Console.ReadLine();
            var isValid = true;
			if (string.IsNullOrWhiteSpace(input))
			{
				isValid = false;
			}
			else
			{
            var time = input.Split(':');
            var hour = Convert.ToInt32(time[0]);
            var minute = Convert.ToInt32(time[1]);
            if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
            {
                isValid = false;
            }
            }
            var result = (isValid) ? "Valid" : "Not valid";
            Console.WriteLine(result);
	}

		/* 4- Write a program and ask the user to enter a few words separated by a space.
		Use the words to create a variable name with PascalCase.
		For example, if the user types: "number of students", display "NumberOfStudents".
		Make sure that the program is not dependent on the input.
		So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */ 
		
	public void Exercise4()
	{
            Console.WriteLine("Type a variable name");
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ');
            var result = "";
            for(var i = 0; i < words.Length; i++)
            {
                result += words[i][0].ToString().ToUpper()+words[i].Substring(1);
            }
            Console.WriteLine(result);
	}	
		
		/* 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
		      So, if the user enters "inadequate", the program should display 6 on the console.*/
			  
	public void Exercise5()
	{
            Console.WriteLine("Type an English word");
            var input = Console.ReadLine();
            var vowels = 0;
            var vowelList = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach(var letter in input.ToLower())
            {
                if (vowelList.Contains(letter))
                {
                    vowels++;
                }
            }
            Console.WriteLine("Number of vowels in {0} is {1}", input, vowels);
	}
    }
}



    

