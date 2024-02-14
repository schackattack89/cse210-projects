public class MonthlyAppointment : Appointment{

    private DateTime _apptTime;

    public MonthlyAppointment(DateTime appt):base(appt){
        _apptTime = appt;
    }
    public override Calendar Schedule(){
        Calendar apptCal = new Calendar(1,2000);
        return apptCal;        
    }
}