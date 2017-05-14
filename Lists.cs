using System;
using System.Collections.Generic;

namespace MoshSolutions
{
    public class Lists
    {
		
		/* 1- When you post a message on Facebook, depending on the number of people who like your post, 
		      Facebook displays different information.
			  If no one likes your post, it doesn't display anything.
			  If only one person likes your post, it displays: [Friend's Name] likes your post.
			  If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
			  If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
			  Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
			  Depending on the number of names provided, display a message based on the above pattern.*/
		
        public void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name");
                var name = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(name))
                {
                    names.Add(name);
                    continue;
                }
                switch (names.Count)
                {
                    case 0:
                        Console.WriteLine("Nothing");
                        break;
                    case 1:
                        Console.WriteLine("{0} likes your post", names[0]);
                        break;
                    case 2:
                        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                        break;
                    default:
                        Console.WriteLine("{0}, {1} and {2} other people like your post", names[0], names[1], names.Count - 2);
                        break;
                }
                break;
            }
		}	
        
		/* 2- Write a program and ask the user to enter their name. 
		      Use an array to reverse the name and then store the result in a new string. 
			  Display the reversed name on the console.*/
	public void Exercise2()
	{
            Console.WriteLine("what's your name ? ");
            string name = Console.ReadLine();
            var charArray = name.ToCharArray();
            Array.Reverse(charArray);
            foreach(var letter in charArray)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
	}

		/* 3- Write a program and ask the user to enter 5 numbers.
  		      If a number has been previously entered, display an error message and ask the user to re-try. 
		      Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/
			  
        public void Exercise3()
	{
            var numbers = new List<int>();
            while (true)
            {
                while (numbers.Count < 5)
                {
                    Console.WriteLine("Type a number ");
                    var input = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(input))
                    {
                        Console.WriteLine("You have previously typed {0}", input);
                        continue;
                    }
                    numbers.Add(input);
                }
                numbers.Sort();
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
                break;
            }
	}

		/* 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
              The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/
	public void Exercise4()
	{
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Type a number or Quit to exit");
                var input = Console.ReadLine();
                if(input != "Quit")
                {
                    numbers.Add(Convert.ToInt32(input));
                    continue;
                }
                for(var number = 0; number < numbers.Count; number++)
                {
                    if (numbers.LastIndexOf(numbers[number]) != number)
                    {
                        numbers.RemoveAt(numbers.LastIndexOf(numbers[number]));
                    }
                }
                foreach(var number in numbers)
                {
                    Console.WriteLine(number);
                }
                break;
            }
	}	
		
		/* 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
     		  If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
		      otherwise, display the 3 smallest numbers in the list. */
		
        public void Exercise5()
	{
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Type a minimum of 5 comma separated numbers");
                var input = Console.ReadLine().Split(',');
                if(input.Length < 5)
                {
                    Console.WriteLine("Invalid list");
                    continue;
                }
                Array.Sort(input);
                Console.WriteLine("The 3 smallest numbers are respectively: {0}, {1} and {2}", input[0], input[1], input[2]);
                break;
            }
	}	
    }
}



    

