public class PromptGenerator{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        string filename = "Journaling_Prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _prompts.Add(line);
        }
        
        //_prompts.Add("What was the best part of my day?");
        //_prompts.Add("What could I have accomplished today with 1 extra hour?");
        //_prompts.Add("Who had an impact on my life today?");
        //_prompts.Add("What made me smile today?");
        //_prompts.Add("If I could do over 1 thing from today what what is?");
        
        Random randomGenerator = new Random();
        int promptChoice = randomGenerator.Next(0,30);

        return _prompts[promptChoice];
    }
}