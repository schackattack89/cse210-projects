using System.Runtime.CompilerServices;

public class GoalManager{
    private  List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(){
        _score = 0;
        _goals = new List<Goal>();
    }
    public void Start(){
        Console.Clear();
        string menuChoice = null;
        while(menuChoice == null){
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Reuse Completed Goal\n\t7. Erase Completed Goals\n\t8. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();
            if(menuChoice == "1"){
                CreateGoal();
                menuChoice = null;
            }
            else if(menuChoice == "2"){
                ListGoalDetails();
                menuChoice = null;
            }
            else if(menuChoice == "3"){
                SaveGoals();
                menuChoice = null;
            }
            else if(menuChoice == "4"){
                Console.Write("Enter goals file name: ");
                string file = Console.ReadLine();
                _goals = LoadGoals(file);
                Console.WriteLine($"\nGoals loaded from {file} file.\n");
                menuChoice = null;
            }
            else if(menuChoice == "5"){
                RecordEvent();
                menuChoice = null;
            }
            else if (menuChoice == "6"){
                ReuseGoal();
                menuChoice = null;
            }
            else if(menuChoice =="7"){
                string choice = "";
                Console.Write("Are you sure you want to erase ALL completed goals? ");
                choice = Console.ReadLine();
                if(choice.ToLower() == "yes"||choice.ToLower() == "y"){
                    EraseCompleted();
                }
                menuChoice = null;
            }
            else if(menuChoice == "8"){
                Environment.Exit(1);
            }
            else{
                Console.Clear();
                Console.WriteLine($"'{menuChoice}' is not a valid selection. Please Try Again.\n");
                menuChoice = null;
            }
        }
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_score} total points.\n");
    }
    public void ListGoalNames(){

    }
    public void ListGoalDetails(){
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals){
            Console.WriteLine($"{_goals.IndexOf(goal)+1}. {goal.GetDetailsString()}");
        }
        Console.WriteLine("");
        
    }
    public void CreateGoal(){
        string goalChoice = null;
        Console.Clear();
        while(goalChoice == null){
            Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalChoice = Console.ReadLine();
            if(goalChoice == "1" || goalChoice == "2"){
                Console.Write("What is the name of this goal? ");
                string goalName = Console.ReadLine();
                Console.Write("Give a short descript of this goal: ");
                string goalDesc = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                string goalPoints = Console.ReadLine();
                if(goalChoice == "1"){
                    SimpleGoal myGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
                    _goals.Add(myGoal);
                }
                else{
                    EternalGoal myGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                    _goals.Add(myGoal);
                }
            }
            else if (goalChoice == "3"){
                Console.Write("What is the name of this goal? ");
                string goalName = Console.ReadLine();
                Console.Write("Give a short description of this goal: ");
                string goalDesc = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                string goalPoints = Console.ReadLine();
                Console.Write("How many times does this goal need to be completed for a bonus? ");
                string goalLength = Console.ReadLine();
                Console.Write($"What is the bonus for accomplishing it {goalLength} times? ");
                string goalBonus = Console.ReadLine();
                ChecklistGoal myGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, Convert.ToInt32(goalLength), Convert.ToInt32(goalBonus));
                _goals.Add(myGoal);
            }
            else{
                Console.Clear();
                Console.WriteLine($"'{goalChoice}' is not a valid selection. Please Try Again.");
                goalChoice = null;
            }
        }
        Console.WriteLine("\nYour goal has been added.\n");

    }
    public void RecordEvent(){
        Console.Clear();
        int listIndex = 1;
        List<Goal> incompleteGoals = new List<Goal>();
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals){
            if(!goal.IsComplete()){
                Console.WriteLine($"{listIndex}. {goal.GetName()}");
                incompleteGoals.Add(goal);
                listIndex++;
            }
        }
        if(incompleteGoals.Count()==0){
            Console.WriteLine("There are no recordable goals. Please add new goals first.");
        }
        else{
            Console.Write("Which goal did you accomplish? ");
            int completedIndex = Convert.ToInt32(Console.ReadLine())-1;
            incompleteGoals[completedIndex].RecordEvent();
            int score = incompleteGoals[completedIndex].GetPoints();
            Console.Clear(); 
            Console.WriteLine($"Congratulations! You earned {score} points!");
            _score += score;
            Console.WriteLine($"\nYou now have {_score} total points.");
            Console.WriteLine("Press ENTER to return to main menu... ");
            Console.ReadLine();
        }
    }
    public void SaveGoals(){
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"Score|{_score}");
            foreach(Goal goal in _goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"\nYour goals have been saved to the {filename} file.\n");
    }
    public List<Goal> LoadGoals(string file){
        List<Goal> loadedGoals = new List<Goal>();
        string filename = file;
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            string [] parts = line.Split("|");
            if(parts[0].ToLower().Contains("score")){
                _score = Convert.ToInt32(parts[1]);
            }
            else if(parts[0].ToLower().Contains("simple")){
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                bool complete = Convert.ToBoolean(parts[4]);
                SimpleGoal myGoal = new SimpleGoal(name, description, points, complete);
                loadedGoals.Add(myGoal);
            }
            else if(parts[0].ToLower().Contains("eternal")){
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                EternalGoal myGoal = new EternalGoal(name, description, points);
                loadedGoals.Add(myGoal);
            }
            else{
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int target = Convert.ToInt32(parts[4]);
                int bonus = Convert.ToInt32(parts[5]);
                int amount = Convert.ToInt32(parts[6]);
                bool complete = Convert.ToBoolean(parts[7]);
                ChecklistGoal myGoal = new ChecklistGoal(name, description, points, target, bonus, amount, complete);
                loadedGoals.Add(myGoal);
            }

        }
        return loadedGoals;
    }
    public void ReuseGoal(){
        List<Goal> completedGoals = new List<Goal>();
        int listIndex = 1;
        List<int> goalIndices = new List<int>();
        Console.WriteLine("Previously completed goals:");
        foreach(Goal goal in _goals){
            if(goal.IsComplete()){
                Console.WriteLine($"{listIndex}. {goal.GetName()}");
                completedGoals.Add(goal);
                listIndex++;
                goalIndices.Add(_goals.IndexOf(goal));
            }
        }
        if(completedGoals.Count()==0){
            Console.WriteLine("<NO COMPLETE GOALS AVAILABLE>");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
        else{
            string execute = null;
            while(execute == null){
                Console.Write("Which goal would you like to reuse? ");
                string userEntry = Console.ReadLine();
                int userInt;
                bool isNumerical = int.TryParse(userEntry, out userInt);
                if(isNumerical){
                    int reuseIndex = Convert.ToInt32(userEntry)-1;
                    int goalIndex = goalIndices[reuseIndex];
                    _goals[goalIndex].SetIsComplete(false);
                    Console.WriteLine($"\n'{completedGoals[reuseIndex].GetName()}' is ready to complete again.");
                    execute = "";
                }
                else{
                    Console.WriteLine("Invalid selection. Please Try Again.");
                }
            }
        }
    }
    public void EraseCompleted(){
        List<Goal> deletedGoals = new List<Goal>();
        List<int> indexToDelete = new List<int>();
        foreach(Goal goal in _goals){
            if(goal.IsComplete()){
                deletedGoals.Add(goal);
                indexToDelete.Add(_goals.IndexOf(goal));
            }
        }
        indexToDelete.Reverse();
        foreach(int index in indexToDelete){
            _goals.Remove(_goals[index]);
        }
        foreach(Goal goal in deletedGoals){
            Console.WriteLine($"'{goal.GetName()}' was deleted from your goals.");
        }
    }
}