using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number game!");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);
        int guess = -1;
        while(magic!=guess){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if(magic < guess){
                Console.WriteLine("Lower");
            }
            else if(magic > guess){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }
    }
}