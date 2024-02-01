public class BreathingActivity : Activity{
    public BreathingActivity(){
        base.SetName("Breathing");
        base.SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.SetDuration(50);
    }
    public void Run(){
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime<futureTime){
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(4);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
}