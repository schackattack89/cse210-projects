public class WeeklyAppointment : Appointment{
    private DateTime _apptTime;

    public WeeklyAppointment(DateTime appt):base(appt){
        _apptTime = appt;
    }
    public override Calendar Schedule(){
        Calendar apptCal = new Calendar(1,2000);
        return apptCal;
    }
}