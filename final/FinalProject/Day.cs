public class Day{
    private int _dayNum;
    private bool _hasEvent = false;
    private List<Appointment> _appointments;

    public Day(int dayNum){
        _dayNum = dayNum;
        _appointments = new List<Appointment>();
    }
    public void SetHasEvent(bool set){
        _hasEvent = set;
    }
    public bool HasEvent(){
        foreach(Appointment appointments in _appointments){
            if(appointments != null){
                _hasEvent = true;
            }
            else{
                _hasEvent = false;
            }
        }
        return _hasEvent;
    }

    public void AddAppointment(DateTime myEvent){
        Appointment thisAppt = new Appointment(myEvent);
        _appointments.Add(thisAppt);
    }
    public void DisplayDay(){
        if(_hasEvent){
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_dayNum);
        }
        else{
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(_dayNum);
        }
    }
}