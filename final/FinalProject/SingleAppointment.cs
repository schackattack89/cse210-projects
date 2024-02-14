public class SingleAppointment : Appointment
{
    
    private DateTime _apptTime;

    public SingleAppointment(DateTime appt):base(appt){
        _apptTime = appt;
    }
    public override Calendar Schedule()
    {
        int year = _apptTime.Year;
        int month = _apptTime.Month;
        int day = _apptTime.Day;
        Calendar apptCal = new Calendar(month, year);
        apptCal.PopulateDays(apptCal.HowManyDays());
        if(apptCal._days[day].HasEvent()){
            Console.WriteLine("You already have something scheduled at that time.");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
        else{
            apptCal._days[day].AddAppointment(_apptTime);
        }
        return apptCal;
    }
}