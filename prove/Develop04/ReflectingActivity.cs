public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> alreadyAsked = new List<int>();
    public ReflectingActivity(){
        base.SetName("Reflecting");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.SetDuration(50);
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime<futureTime){    
            DisplayQuesiton();
            Thread.Sleep(5000);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        _prompts = new List<string>();
        string filename = "Reflections_Prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _prompts.Add(line);
        }
        
        Random randomGenerator = new Random();
        int promptChoice = randomGenerator.Next(0,9);

        return _prompts[promptChoice];
    }
    public string GetRandomQuestion(){
        string currentQuestion = "";
        _questions = new List<string>();
        string filename = "Questions_Prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _questions.Add(line);
        }
        
        Random randomGenerator = new Random();
        int questionChoice = randomGenerator.Next(0,9);
        if(alreadyAsked.Contains(questionChoice)){
            currentQuestion = "\b \b";
        }
        else{
            currentQuestion = _questions[questionChoice];
        }
        
        alreadyAsked.Add(questionChoice);

        return currentQuestion;
    }
    public void DisplayPrompt(){
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---\n");
    }
    public void DisplayQuesiton(){
        string question = GetRandomQuestion();
        Console.Write($"> {question} \n");
        ShowSpinner(3);

    }
}