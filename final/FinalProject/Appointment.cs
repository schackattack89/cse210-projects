public class Appointment{
    private DateTime _apptTime;
    protected string _description;
    protected List<string> _appointmentsList = new List<string>();

    public Appointment(){
        _apptTime = new DateTime();
        _description = "";
    }
    public Appointment(DateTime appt, string description){
        _apptTime = appt;
        _description = description;
    }
    public virtual void GetUserAppt()
    {
        Console.Write("Which Year? ");
        int yearInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("Which Month? ");
        string monthInputStr = Console.ReadLine();
        int monthInputNum = Convert.ToDateTime(monthInputStr + "01, 1900").Month;
        Console.Write("Which Day? ");
        int dayInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("What Time (HH:MM)? ");
        string timeInput = Console.ReadLine();
        string[] parts = timeInput.Split(":");
        int hourInput = Convert.ToInt32(parts[0]);
        int minuteInput = Convert.ToInt32(parts[1]);
        
        DateTime userDateTime = new DateTime(yearInput, monthInputNum, dayInput, hourInput, minuteInput, 0);
        _apptTime = userDateTime;
        
        Console.Write("Description: ");
        _description = Console.ReadLine();
    }
    public virtual Day Schedule(Calendar currentCal){
        bool apptExists = false;
        foreach (Appointment currentAppt in currentCal._days[GetDay()-1]._appointments)
        {
            if (currentAppt.GetDateString() == GetDateString())
            {
                // Console.WriteLine($"ERROR: You already have an appointment scheduled for {GetDateString()}");
                // Console.Write("Press ENTER to return to main menu...");
                // Console.ReadLine();
                apptExists = true;
            }
        }
        if (!apptExists)
        {
            currentCal._days[GetDay()-1].AddAppointment(GetDate(), GetDescription());
            currentCal._days[GetDay()-1].SetHasEvent(true);
        }
        return currentCal._days[GetDay()-1];
    }

    public string GetDateString(){
        return $"{_apptTime.Month}/{_apptTime.Day}/{_apptTime.Year} @ {_apptTime.ToString("hh:mm tt")}";
    }
     public string GetDescription(){
        return _description;
    }
    public DateTime GetDate(){
        return _apptTime;
    }
    public int GetDay(){
        return _apptTime.Day;
    }
    public void SaveToFile(string file, List<Appointment> appointments)
    {
        string fileName = file;
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Appointment appt in appointments){
                outputFile.WriteLine($"{appt.GetDateString()}|{appt.GetDescription()}");
            }          
        }
    }
}