public class Day{
    private int _dayNum;
    private bool _hasEvent = false;

    public Day(int dayNum){
        _dayNum = dayNum;
    }
    public void SetHasEvent(bool set){
        _hasEvent = set;
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