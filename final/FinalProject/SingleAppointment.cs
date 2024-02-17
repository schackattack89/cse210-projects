public class SingleAppointment : Appointment
{

    private DateTime _apptTime;

    public SingleAppointment()
    {
        _apptTime = new DateTime();
        _description = "";

    }
    public SingleAppointment(DateTime appt, string desc) : base(appt, desc)
    {
        _apptTime = appt;
        _description = desc;
    }
    public override Day Schedule(Calendar currentCal)
    {
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

}