public class Appointment{
    private DateTime _apptTime = new DateTime();

    public Appointment(DateTime appt){
        _apptTime = appt;
    }
    public virtual Calendar Schedule(){
        Calendar apptCal = new Calendar(1,2000);
        return apptCal;
    }
}