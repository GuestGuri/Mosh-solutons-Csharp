using System;

namespace MoshSolutions
{
    public class Loops
    {
		/* This method is able to generate a random password for a given length*/
		
        public void RandomPasswords()
        {
            const int PasswordLength = 16;
            for(var i = 0; i <= PasswordLength; i++)
            {
                Console.Write((char)('A'+random.Next(0, 52)));
            }
            Console.WriteLine();
		}

		/* 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
   		   Display the count on the console.*/
		
	public void Exercise1()
	{
            for(var i = 0; i <= 100; i++)
            {
                var result = (i % 3 == 0) ? "divisible by 3" : "not divisible by 3";
                Console.WriteLine("{0} is {1}",i, result);
            }
	}
		
		/* 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
      		  For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
			  
	public void Exercise3()
        {		
            Console.WriteLine("Type a number");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for(var i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}! = {1}", input, result);
	}

		/* 4- Write a program that picks a random number between 1 and 10.
	       	  Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
			  otherwise, display “You lost".*/
			  
        public void Exercise4()
        {		
            var random = new Random();
            var secret = random.Next(1, 10);
            var attempts = 0;
            while(attempts < 4)
            {
                Console.WriteLine("Guess the secret");
                var guess = Convert.ToInt32(Console.ReadLine());
                if(guess == secret)
                {
                    Console.WriteLine("Bingo !");
                    break;
                }
                attempts++;
            }
            if (attempts == 4)
            {
                Console.WriteLine("You lost");
            }
	}
		
		/* 5- Write a program and ask the user to enter a series of numbers separated by comma.
    		  Find the maximum of the numbers and display it on the console.
		       For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/
			   
	public void Exercise5()
	{
            Console.WriteLine("Type a serie of comma separated numbers");
            var input = Console.ReadLine();
            var i = 0;
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach(var number in numbers)
            {
                if(Convert.ToInt32(number) > max)
                {
                    max = Convert.ToInt32(number);
                }
            }
            Console.WriteLine("The max of this list is: {0}", max);
	}

    }
}



    
    

