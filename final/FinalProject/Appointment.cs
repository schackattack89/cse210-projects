public class Appointment{
    private DateTime _apptTime = new DateTime();

    public Appointment(DateTime appt){
        _apptTime = appt;
    }
    public virtual void Schedule(){
        
    }
}