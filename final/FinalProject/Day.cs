public class Day
{
    private int _dayNum;
    private bool _hasEvent = false;
    public List<Appointment> _appointments;

    public int GetDay()
    {
        return _dayNum;
    }
    public Day(int dayNum)
    {
        _dayNum = dayNum;
        _appointments = new List<Appointment>();
    }
    public void SetHasEvent(bool set)
    {
        _hasEvent = set;
    }
    public void ListAppointments()
    {
        foreach (Appointment appt in _appointments)
        {
            Console.WriteLine($"{appt.GetDateString()} : {appt.GetDescription()}");
        }
    }
    public bool HasEvent()
    {
        foreach (Appointment appointments in _appointments)
        {
            if (appointments != null)
            {
                _hasEvent = true;
            }
            else
            {
                _hasEvent = false;
            }
        }
        return _hasEvent;
    }

    public void AddAppointment(DateTime myEvent, string desc)
    {
        Appointment thisAppt = new Appointment(myEvent, desc);
        _appointments.Add(thisAppt);
    }
    public void DisplayDay()
    {
        if(_dayNum == 99){
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ");
        }
        else if (_hasEvent)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_dayNum);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(_dayNum);
        }
    }
}