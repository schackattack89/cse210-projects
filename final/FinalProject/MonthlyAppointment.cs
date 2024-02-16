public class MonthlyAppointment : Appointment{

    private DateTime _apptTime;
    private string _description;

    public MonthlyAppointment(){}
    public MonthlyAppointment(DateTime appt, string desc):base(appt, desc){
        _apptTime = appt;
    }

    public override void GetUserAppt(){
        
    }
    public override Day Schedule(Calendar currentCal){
        Day apptDay = new Day(1);
        return apptDay;      
    }
}