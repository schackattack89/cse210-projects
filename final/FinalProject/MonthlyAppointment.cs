public class MonthlyAppointment : Appointment{

    private DateTime _apptTime;
    private List<DateTime> _apptTimes = new List<DateTime>();
    private DateTime _startDate;
    private int _duration;
    

    public MonthlyAppointment(){}
    public MonthlyAppointment(DateTime appt, string desc):base(appt, desc){
        _apptTime = appt;
    }

    public override void GetUserAppt(){
        Console.WriteLine("*Enter the START of recurring weekly appointment as MM/DD/YYYY*");
        Console.Write("Month: ");
        int startMonth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Day: ");
        int startDay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int startYear = Convert.ToInt32(Console.ReadLine());
        _startDate = new DateTime(startYear, startMonth, startDay);
        
        Console.Write("How many months does this appointment last? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("What TIME (HH:MM) is the appointment? ");
        string timeInput = Console.ReadLine();
        string[] parts = timeInput.Split(":");
        int hourInput = Convert.ToInt32(parts[0]);
        int minuteInput = Convert.ToInt32(parts[1]);

        DateTime monAppt = new DateTime(_startDate.Year, _startDate.Month, _startDate.Day, hourInput, minuteInput, 0);
        _apptTimes.Add(monAppt);
        for(int i=1; i<_duration; i++){
            monAppt = monAppt.AddMonths(1);
            _apptTimes.Add(monAppt);
        }
        
        Console.Write("Description: ");
        _description = Console.ReadLine();
        
    }
    public override Day Schedule(Calendar currentCal){
        bool apptExists = false;
        foreach (Appointment currentAppt in currentCal._days[GetDay()-1]._appointments)
        {
            if (currentAppt.GetDateString() == GetDateString())
            {
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
    public List<DateTime> GetMonthlyApptList(){
        return _apptTimes;
    }
}