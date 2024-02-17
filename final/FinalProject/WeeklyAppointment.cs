using System.Globalization;

public class WeeklyAppointment : Appointment
{
    private List<DateTime> _apptTimes = new List<DateTime>();
    private DateTime _startDate;

    public WeeklyAppointment(){

    }
    public WeeklyAppointment(DateTime appt, string desc) : base(appt, desc)
    {

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
        
        Console.Write("How many weeks does this appointment last? ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.Write("What TIME (HH:MM) is the appointment? ");
        string timeInput = Console.ReadLine();
        string[] parts = timeInput.Split(":");
        int hourInput = Convert.ToInt32(parts[0]);
        int minuteInput = Convert.ToInt32(parts[1]);

        DateTime wkAppt = new DateTime(_startDate.Year, _startDate.Month, _startDate.Day, hourInput, minuteInput, 0);
        _apptTimes.Add(wkAppt);
        for(int i=1; i<duration; i++){
            wkAppt = wkAppt.AddDays(7);
            _apptTimes.Add(wkAppt);
        }
            
        Console.Write("Description: ");
        _description = Console.ReadLine();
    }
    public override Day Schedule(Calendar currentCal)
    {
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
    public List<DateTime> GetWeeklyApptList(){
        return _apptTimes;
    }
}