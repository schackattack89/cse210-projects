public class SingleAppointment : Appointment
{
    public SingleAppointment(){
    }
    public SingleAppointment(DateTime appt, string desc) : base(appt, desc)
    {
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

}