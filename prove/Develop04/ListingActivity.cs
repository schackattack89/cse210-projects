public class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(){
        base.SetName("Listing");
        base.SetDescription("This activity will help you list items that pertain to certain prompts.");
        base.SetDuration(50);
        _prompts = new List<string>();
        _count = 0;
    }
    public void Run(){

    }
    public string GetRandomPrompt(){
        return "";
    }
    public List<string> GetListFromUser(){
        List<string> userList = new List<string>();
        return userList;
    }
}