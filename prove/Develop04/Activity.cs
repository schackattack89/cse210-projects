public class Activity{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(){
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public void DisplayStartingMessage(){

    }
    public void DisplayEndingMessage(){

    }
    public void ShowSpinner(int seconds){

    }
    public void ShowCountDown(int seconds){

    }
}