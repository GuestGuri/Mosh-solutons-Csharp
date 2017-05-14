using System;

namespace MoshSolutions
{
    public class Conditionals
    {
		/*  1- Write a program and ask the user to enter a number. 
		    The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
			Otherwise, display "Invalid". (This logic is used a lot in applications 
			where values entered into input boxes need to be validated.) */
			
        public void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10 \n");
            var input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            string result = (i >= 1 && i <= 10) ? "Valid input" : "Invalid input";
            Console.WriteLine(result);
	}
		
        /* 2- Write a program which takes two numbers from the console and displays the maximum of the two.*/
		
	public void Exercise2()
	{
            Console.WriteLine("Enter 2 numbers \n");
            var input1 = Convert.ToInt32(Console.ReadLine());
            var input2 = Convert.ToInt32(Console.ReadLine());
            var result = (input1 >= input2) ? input1 : input2;
            Console.WriteLine("The max is: {0}", result);
            if(input1 >= input2)  //classical way
            {
                Console.WriteLine("The max is: {0}", input1);
            }
            else
            {
                Console.WriteLine("The max is: {0}", input2);
            }
	}
        
		/* 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. */
		
	public void Exercise3()
	{
            Console.WriteLine("Enter height and width \n");
            var height = Convert.ToInt32(Console.ReadLine());
            var width = Convert.ToInt32(Console.ReadLine());
            var result = (height >= width) ? "Portrait" : "Landscape";
            Console.WriteLine(result);
	}
		
    }
}



    
    

