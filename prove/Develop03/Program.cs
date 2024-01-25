using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer program!");
        string book = "";
        int chapter = 0;
        int startingVerse = 0;
        int endingVerse = 0;
        
        Console.WriteLine("Which book of scripture would you like to practice?");
        book = Console.ReadLine();
        Console.WriteLine("Which chapter?");
        chapter = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose single verse (S) or multiple verses (M)?");
        string multiples = Console.ReadLine().ToLower();
            if (multiples == "s"){
                Console.WriteLine("Which verse?");
                startingVerse = Convert.ToInt32(Console.ReadLine());
            }
            else{
                Console.WriteLine("Starting verse?");
                startingVerse = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ending verse?");
                endingVerse = Convert.ToInt32(Console.ReadLine());
            }
        
        Console.Clear();
        Reference reference = new Reference(book, chapter, startingVerse);
        if (endingVerse == 0){
            reference.SetReference(book, chapter, startingVerse);
        }
        else{
            reference.SetReference(book, chapter, startingVerse, endingVerse);
        }

        VerseGenerator verseGenerator = new VerseGenerator();
        string textOfVerse = "";
        if(endingVerse==0){
            textOfVerse = verseGenerator.GetSingleVerse(book, chapter, startingVerse);
        }
        else{
            textOfVerse = verseGenerator.GetMultipleVerse(book, chapter, startingVerse, endingVerse);
        }
        Console.Clear();
        
        Scripture scripture = new Scripture(reference, textOfVerse);
        Console.WriteLine("How many words would you like hidden at a time?");
        int amountHidden = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        while(!scripture.IsCompletelyHidden()){
            Console.Write(reference.GetDisplayText()+" ");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            if(Console.ReadLine().ToLower() == "quit"){
                System.Environment.Exit(1);
            }
            else{
                Console.Clear();
            }
            scripture.HideRandomWords(amountHidden);
        }
        Console.Clear();
        Console.Write(reference.GetDisplayText()+" ");
        Console.WriteLine(scripture.GetDisplayText());
        Console.ReadLine();

    }
}