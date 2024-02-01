using System.ComponentModel;
using System.Text;

public class Activity{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(){
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        string logDate = DateTime.Now.ToString("MM/dd/yyyy");
        string logTime = DateTime.Now.ToString("hh:mm");
        using(StreamWriter outputFile = File.AppendText("Activity_Log.txt")){
            outputFile.WriteLine($"On {logDate} at {logTime} you completed {_duration} seconds of the {_name} Activity.");
        }

    }
    public void viewLog(){
        Console.WriteLine("Here is your Midfulness Activities log:");
        string [] lines = System.IO.File.ReadAllLines("Activity_Log.txt");
        foreach(string line in lines){
            Console.WriteLine(line);
        }
        Console.Write("Press enter to return to main menu...");
        Console.ReadLine();
    }
    public void ShowSpinner(int cycles){
        for(int i=0; i<cycles; i++){
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("\u25CB");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\u25D4");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\u25D1");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\u25D5");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\u25CF");
            Thread.Sleep(400);
            Console.Write("\b \b");
        }

    }
    public void ShowCountDown(int seconds){
        for(int i=0; i<seconds; i++){
            int current = seconds - i;
            Console.Write(current);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}