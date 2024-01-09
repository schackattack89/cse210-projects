using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        float percentGrade = float.Parse(Console.ReadLine());
        string letter = "";
        if (percentGrade >= 90.0){
           letter = "A";
        }
        else if(percentGrade >= 80.0){
            letter = "B";
        }
        else if(percentGrade >= 70.0){
            letter = "C";
        }
        else if(percentGrade >= 60.0){
            letter = "D";
        }
        else{
            letter = "F";
        }
        string modifier = "";
        if(percentGrade%10 >= 7 && letter!="A" && letter!="F"){
            modifier = "+";
        }
        else if(percentGrade%10 <= 3 && letter!="F"){
            modifier = "-";
        }
        else{
            modifier = null;
        }
        Console.WriteLine($"A {percentGrade}% is a grade of '{letter}{modifier}'." );
        if(percentGrade >= 70.0){
            Console.WriteLine("Congratulations! You've passed the class!");
        }
        else{
            Console.WriteLine("You didn't pass the class. Better luck next time.");
        }
    }
}