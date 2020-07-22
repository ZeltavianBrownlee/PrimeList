using System;


namespace PrimeList
{
    class Program
    {
        //create function to check for prime number
        static bool isPrime(int x)
        {

            //increment through numbers to see if number is divisible by any other numbers
            for (int i = 2; i < x; i++)
            {
                //not prime
                if (x % i == 0)
                {
                    return false;
                }

            }//end for loop
            //prime number
            return true;


        }
        static void Main(string[] args)
        {
            //declare and intialize variables
            int number = 0;

            //prompt for and get number
            Console.Write("Please enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            //for loop to increment through user enter number
            for(int i =2; i < number; i++ )
            {
                //call function and display number if bool is true
                if (isPrime(i) == true)
                {
                    Console.Write("{0}   ", i);
                }

            }//end for loop

            Console.ReadKey();
        }

    }
}
