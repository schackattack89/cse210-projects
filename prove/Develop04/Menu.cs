public class Menu{
    private List<string> _menuItems = new List<string>();
    private int _menuCounter = 1;
    private int _menuSelction = 0;
    public Menu(){
        _menuItems.Add("Start breathing activity");
        _menuItems.Add("Start reflecting activity");
        _menuItems.Add("Start listing activity");
        _menuItems.Add("View Activity Log");
        _menuItems.Add("Quit");
    }
    public Menu(string a, string b, string c){
        _menuItems.Add(a);
        _menuItems.Add(b);
        _menuItems.Add(c);
        _menuItems.Add("Quit");
    }
    public void ShowMenu(){
        Console.Clear();
        Console.WriteLine("Menu Options:");
        foreach(string item in _menuItems){
            Console.WriteLine($"{_menuCounter}. {item}");
            _menuCounter++;
        }
        Console.Write("Select a choice from the menu: ");
        _menuSelction = Convert.ToInt32(Console.ReadLine());
    }
    public int GetMenuSelection(){
        return _menuSelction;
    }
    public void SetMenuCounter(int i){
        _menuCounter = i;
    }
}