using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Edward Schack", "Programming with Classes");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMathAssignment = new MathAssignment("Edward Schack", "Fractions", "3.2","1-5");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        WritingAssignment myWritingAssignment = new WritingAssignment("Edward Schack", "European History", "The Causes of World War II");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}