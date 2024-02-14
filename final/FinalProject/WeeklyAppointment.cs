public class WeeklyAppointment : Appointment{
    private DateTime _apptTime;

    public WeeklyAppointment(DateTime appt):base(appt){
        _apptTime = appt;
    }
    public override void Schedule(){

        Console.Write("Which year? ");
        int year = Convert.ToInt32(Console.ReadLine());
    }
}