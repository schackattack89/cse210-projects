using System.IO;

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry currentEntry = new Entry();
        PromptGenerator generatedPrompt = new PromptGenerator();
        string currentPrompt = generatedPrompt.GetRandomPrompt();
        currentEntry._promptText = currentPrompt;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        currentEntry._date = dateText;
        Console.WriteLine(currentPrompt);
        Console.Write("> ");
        currentEntry._entryText = Console.ReadLine();
        _entries.Add(currentEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string fileName = file;
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine(entry._date+"|"+entry._promptText+"|"+entry._entryText);
            }          
        }
    }
    public void LoadFromFile(string file){
        string filename = file;
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            Entry loadedEntry = new Entry();
            string [] parts = line.Split("|");
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            Console.WriteLine("Date: "+parts[0]+" - Prompt: "+parts[1]);
            Console.WriteLine(parts[2]);
            _entries.Add(loadedEntry);
        }

    }
}