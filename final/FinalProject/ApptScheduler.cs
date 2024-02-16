public class ApptScheduler
{
    private List<DateTime> _apptList;
    private string _description = "";
    private bool _isTimeAvailable;

    public ApptScheduler()
    {
        _apptList = new List<DateTime>();
        _isTimeAvailable = true;
    }
    public string GetUserAppt()
    {

        Console.Write("Which Year? ");
        int yearInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("Which Month? ");
        string monthInputStr = Console.ReadLine();
        int monthInputNum = Convert.ToDateTime(monthInputStr + "01, 1900").Month;

        Console.Write("Which Day? ");
        int dayInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("What Time? ");
        string timeInput = Console.ReadLine();
        string[] parts = timeInput.Split(":");
        int hourInput = Convert.ToInt32(parts[0]);
        int minuteInput = Convert.ToInt32(parts[1]);

        Console.Write("Description: ");
        _description = Console.ReadLine();
    
        DateTime myDateTime = new DateTime(yearInput, monthInputNum, dayInput, hourInput, minuteInput, 0);

        return $"{myDateTime} : {_description}";
    }
    
    public bool IsTimeAvailable(DateTime apptTime)
    {
        if (_apptList.Contains(apptTime))
        {
            _isTimeAvailable = false;
        }
        else
        {
            _isTimeAvailable = true;
        }
        return _isTimeAvailable;
    }

    public void ScheduleAppt(DateTime apptTime)
    {
        _apptList.Add(apptTime);
    }
    
    public string GetDescription(){
        return _description;
    }
}