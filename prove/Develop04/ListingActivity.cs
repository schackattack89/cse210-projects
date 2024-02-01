public class ListingActivity : Activity{
    private int _count = 0;
    private List<string> _prompts;
    public ListingActivity(){
        base.SetName("Listing");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.SetDuration(50);
        _prompts = new List<string>();
    }
    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime<futureTime){    
            Console.Write("> ");
            string entry = Console.ReadLine();
            currentTime = DateTime.Now;
            _count++;
        }
        if(_count == 1){
            Console.WriteLine("\n You listed 1 item.");
        }
        else{
            Console.WriteLine($"\nYou listed {_count} items.");
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        _prompts = new List<string>();
        string filename = "Listing_Prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _prompts.Add(line);
        }
        
        Random randomGenerator = new Random();
        int promptChoice = randomGenerator.Next(0,19);

        return _prompts[promptChoice];
    }
    /*public List<string> GetListFromUser(){
        List<string> userList = new List<string>();
        return userList;
    }*/
}