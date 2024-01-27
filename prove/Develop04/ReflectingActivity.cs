public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(){
        base.SetName("Reflecting");
        base.SetDescription("This activity will help you reflect on certain times in your life.");
        base.SetDuration(50);
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run(){

    }
    public string GetRandomPrompt(){
        return "";
    }
    public string GetRandomQuestion(){
        return "";
    }
    public void DisplayPrompt(){

    }
    public void DisplayQuesiton(){

    }
}