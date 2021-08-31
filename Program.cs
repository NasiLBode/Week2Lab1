using System;

namespace Week2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print a message to the screen
            Console.WriteLine("Hello Out There.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter:");

            // declare three integer variables
            int n1, n2, n3, sum, product;
            double division;

            string userInput;
            userInput = Console.ReadLine();
            n1 = int.Parse(userInput);
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            //calculate the sum of these three numbers
            sum = n1 + n2 + n3;
            //calculate the product of these three numbers
            product = n1 * n2 * n3;
            //calculate the division of the sum and product
            division = product / (double)sum;
            //print a message along with the sum and product of the three numbers
            Console.WriteLine("The sum of those three numbers is: " + sum);
            Console.WriteLine("The prodcut of those three numbers is: " + product);           
            Console.WriteLine("The division of those the sum of these three numbers by the product is: " + division);          
            //just to pause the screen
            Console.ReadLine();
        }
    }
}
