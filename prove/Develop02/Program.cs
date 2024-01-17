using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        int choice = 0;
        while (choice != 5){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                journal1.AddEntry();
            }
            else if (choice == 2){
                journal1.DisplayAll();
            }
            else if (choice == 3){
                Console.WriteLine("File name? ");
                string file = Console.ReadLine();
                journal1.LoadFromFile(file);
            }
            else if (choice == 4){
                Console.WriteLine("File name: ");
                string file = Console.ReadLine();
                journal1.SaveToFile(file);
            }
        }
    }
}