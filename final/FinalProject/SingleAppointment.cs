public class SingleAppointment : Appointment
{

    
    private DateTime _apptTime;

    public SingleAppointment(DateTime appt):base(appt){
        _apptTime = appt;
    }
    public override void Schedule()
    {
        
    }
}