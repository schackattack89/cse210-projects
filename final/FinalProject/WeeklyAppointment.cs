using System.Globalization;

public class WeeklyAppointment : Appointment
{
    private List<DateTime> _apptTimes = new List<DateTime>();
    private DateTime _startDate;
    private DateTime _endDate;

    public WeeklyAppointment(){

    }
    // public WeeklyAppointment(DateTime appt, string desc) : base(appt, desc)
    // {
    //     _apptTime = appt;
    // }
    public override void GetUserAppt(){
        Console.WriteLine("*Enter the START of recurring weekly appointment as MM/DD/YYYY*");
        Console.Write("Month: ");
        int startMonth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Day: ");
        int startDay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int startYear = Convert.ToInt32(Console.ReadLine());
        _startDate = new DateTime(startYear, startMonth, startDay);
        
        Console.WriteLine("*Enter the END of recurring weekly appointment as MM/DD/YYYY*");
        Console.Write("Month: ");
        int endMonth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Day: ");
        int endDay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int endYear = Convert.ToInt32(Console.ReadLine());
        _endDate = new DateTime(endYear, endMonth, endDay);
        
        int spanMonths = ((_endDate.Year - _startDate.Year) * 12) + _endDate.Month - _startDate.Month;

        Console.Write("What TIME (HH:MM) is the appointment? ");
        string timeInput = Console.ReadLine();
        string[] parts = timeInput.Split(":");
        int hourInput = Convert.ToInt32(parts[0]);
        int minuteInput = Convert.ToInt32(parts[1]);

        DateTime wkAppt;
        int runningMonth = _startDate.Month;
        for(int i=0; i<spanMonths; i++){
            if(runningMonth<=12){
                wkAppt = new DateTime(_startDate.Year, (_startDate.Month)+i, _startDate.Day, hourInput, minuteInput, 0);
                runningMonth++;
            }
            else if(runningMonth<=24){
                wkAppt = new DateTime((_startDate.Year)+1, (_startDate.Month)+i-12, _startDate.Day, hourInput, minuteInput, 0);
            }
            else{
                wkAppt = new DateTime((_startDate.Year)+2, (_startDate.Month)+i-24, _startDate.Day, hourInput, minuteInput, 0);
            }
            _apptTimes.Add(wkAppt);

        }    
        // DateTime userDateTime = new DateTime(yearInput, monthInputNum, dayInput, hourInput, minuteInput, 0);
        // _apptTime = userDateTime;
        
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
                Console.WriteLine($"ERROR: You already have an appointment scheduled for {GetDateString()}");
                Console.Write("Press ENTER to return to main menu...");
                Console.ReadLine();
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
}