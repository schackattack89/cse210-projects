public class Calendar{
    private int _monthNum;
    private int _year;
    private string _firstDayOfWeek;
    private int _numOfDays;
    private List<int> shortMonths = new List<int>{4,6,9,11};
    private List<int> longMonths = new List<int>{1,3,5,7,8,10,12};
    public List<Day> _days = new List<Day>();

    public Calendar(int month, int year){
        _monthNum = month;
        _year = year;

        DateTime thisMonth = new DateTime(year, month, 1);
        _firstDayOfWeek = thisMonth.DayOfWeek.ToString();
    }

    public int GetMonthNum(){
        return _monthNum;
    }
    public int HowManyDays(){
        if(shortMonths.Contains(_monthNum)){
            _numOfDays = 30;
        }
        else if(longMonths.Contains(_monthNum)){
            _numOfDays = 31;
        }
        else if((_monthNum==2)&&(((_year%4==0)&&(_year%100!=0))||(_year%400==0))){
                _numOfDays = 29;
        }
        else{
            _numOfDays =28;
        }
        return _numOfDays;
    }

    public List<Day> PopulateDays(int numOfDays){
         for(int i = 1; i<=numOfDays; i++){
            Day currentDay = new Day(i);
            _days.Add(currentDay);
        }
        return _days;
    }
    public void drawCalendar(int daysCount, List<Day> days){
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Su\tM\tT\tW\tR\tF\tS ");
        Console.ResetColor();
        if(daysCount ==28){
            switch(_firstDayOfWeek.ToLower()){
                case "sunday":
                    Console.Write(" "); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay(); Console.Write("\t"); days[6].DisplayDay();
                    Console.Write("\n "); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay();
                    Console.Write("\n "); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay();
                    Console.Write("\n "); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "monday":
                    Console.Write(" "); Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay();
                    Console.Write("\n ");days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay();
                    Console.Write("\n ");days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay();
                    Console.Write("\n ");days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay();
                    Console.Write("\n ");days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "tuesday":
                    Console.Write(" ");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay();
                    Console.Write("\n ");days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay();
                    Console.Write("\n ");days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay();
                    Console.Write("\n ");days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay();
                    Console.Write("\n ");days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "wednesday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay();
                    Console.Write("\n ");days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay();
                    Console.Write("\n ");days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay();
                    Console.Write("\n ");days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay();
                    Console.Write("\n ");days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "thursday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay();
                    Console.Write("\n ");days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay();
                    Console.Write("\n ");days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay();
                    Console.Write("\n ");days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay();
                    Console.Write("\n ");days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "friday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();
                    Console.Write("\n ");days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();
                    Console.Write("\n ");days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay();
                    Console.Write("\n ");days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay();
                    Console.Write("\n ");days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
                case "saturday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();
                    Console.Write("\n ");days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();
                    Console.Write("\n ");days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay();
                    Console.Write("\n ");days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay();
                    Console.Write("\n ");days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.WriteLine();
                    break;
            }
        }
        else if (daysCount ==29){
            switch(_firstDayOfWeek.ToLower()){
                case "sunday":
                    Console.Write(" "); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay(); Console.Write("\t"); days[6].DisplayDay();
                    Console.Write("\n "); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay();
                    Console.Write("\n "); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay();
                    Console.Write("\n "); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.Write("\n "); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "monday":
                    Console.Write(" ");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay();
                    Console.Write("\n "); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay();
                    Console.Write("\n "); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay();
                    Console.Write("\n "); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay();
                    Console.Write("\n "); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "tuesday":
                    Console.Write(" ");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay();
                    Console.Write("\n "); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay();
                    Console.Write("\n "); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay();
                    Console.Write("\n "); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay();
                    Console.Write("\n "); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "wednesday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay();
                    Console.Write("\n "); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay();
                    Console.Write("\n "); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay();
                    Console.Write("\n "); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay();
                    Console.Write("\n "); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "thursday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay();
                    Console.Write("\n "); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay();
                    Console.Write("\n "); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay();
                    Console.Write("\n "); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay();
                    Console.Write("\n "); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "friday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();
                    Console.Write("\n "); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();
                    Console.Write("\n "); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay();
                    Console.Write("\n "); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay();
                    Console.Write("\n "); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
                case "saturday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();
                    Console.Write("\n "); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();
                    Console.Write("\n "); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay();
                    Console.Write("\n "); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay();
                    Console.Write("\n "); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.WriteLine();
                    break;
            }
        }
        else if(daysCount == 30){
            switch(_firstDayOfWeek.ToLower()){
                case "sunday":
                    Console.Write(" "); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay(); Console.Write("\t"); days[6].DisplayDay();
                    Console.Write("\n "); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay();
                    Console.Write("\n "); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay();
                    Console.Write("\n "); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.Write("\n "); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "monday":
                    Console.Write(" ");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay();
                    Console.Write("\n "); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay();
                    Console.Write("\n "); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay();
                    Console.Write("\n "); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay();
                    Console.Write("\n "); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "tuesday":
                    Console.Write(" ");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay();
                    Console.Write("\n "); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay();
                    Console.Write("\n "); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay();
                    Console.Write("\n "); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay();
                    Console.Write("\n "); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "wednesday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay();
                    Console.Write("\n "); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay();
                    Console.Write("\n "); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay();
                    Console.Write("\n "); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay();
                    Console.Write("\n "); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "thursday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay();
                    Console.Write("\n "); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay();
                    Console.Write("\n "); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay();
                    Console.Write("\n "); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay();
                    Console.Write("\n "); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "friday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();
                    Console.Write("\n "); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();
                    Console.Write("\n "); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay();
                    Console.Write("\n "); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay();
                    Console.Write("\n "); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
                case "saturday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();
                    Console.Write("\n "); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();
                    Console.Write("\n "); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay();
                    Console.Write("\n "); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay();
                    Console.Write("\n "); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.Write("\n "); days[29].DisplayDay();
                    Console.WriteLine();
                    break;
            }
        }
        else{
            switch(_firstDayOfWeek.ToLower()){
                case "sunday":
                    Console.Write(" "); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay(); Console.Write("\t"); days[6].DisplayDay();
                    Console.Write("\n "); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay();
                    Console.Write("\n "); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay();
                    Console.Write("\n "); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay();
                    Console.Write("\n "); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "monday":
                    Console.Write(" ");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay(); Console.Write("\t"); days[5].DisplayDay();
                    Console.Write("\n "); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay();
                    Console.Write("\n "); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay();
                    Console.Write("\n "); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay();
                    Console.Write("\n "); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "tuesday":
                    Console.Write(" ");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay(); Console.Write("\t"); days[4].DisplayDay();
                    Console.Write("\n "); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay();
                    Console.Write("\n "); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay();
                    Console.Write("\n "); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay();
                    Console.Write("\n "); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "wednesday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay();Console.Write("\t"); days[2].DisplayDay();Console.Write("\t"); days[3].DisplayDay();
                    Console.Write("\n "); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay();
                    Console.Write("\n "); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay();
                    Console.Write("\n "); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay();
                    Console.Write("\n "); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "thursday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay();Console.Write("\t"); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay();
                    Console.Write("\n "); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay();
                    Console.Write("\n "); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay();
                    Console.Write("\n "); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay();
                    Console.Write("\n "); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "friday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");    Console.Write("\t"); days[0].DisplayDay(); Console.Write("\t"); days[1].DisplayDay();
                    Console.Write("\n "); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();  Console.Write("\t"); days[8].DisplayDay();
                    Console.Write("\n "); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay(); Console.Write("\t"); days[15].DisplayDay();
                    Console.Write("\n "); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay(); Console.Write("\t"); days[22].DisplayDay();
                    Console.Write("\n "); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay(); Console.Write("\t"); days[29].DisplayDay();
                    Console.Write("\n "); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
                case "saturday":
                    Console.Write(" ");   Console.Write("\t");  Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t");   Console.Write("\t"); days[0].DisplayDay();
                    Console.Write("\n "); days[1].DisplayDay(); Console.Write("\t"); days[2].DisplayDay(); Console.Write("\t"); days[3].DisplayDay();  Console.Write("\t"); days[4].DisplayDay();  Console.Write("\t"); days[5].DisplayDay();  Console.Write("\t"); days[6].DisplayDay();  Console.Write("\t"); days[7].DisplayDay();
                    Console.Write("\n "); days[8].DisplayDay();  Console.Write("\t"); days[9].DisplayDay(); Console.Write("\t"); days[10].DisplayDay(); Console.Write("\t"); days[11].DisplayDay(); Console.Write("\t"); days[12].DisplayDay(); Console.Write("\t"); days[13].DisplayDay(); Console.Write("\t"); days[14].DisplayDay();
                    Console.Write("\n "); days[15].DisplayDay(); Console.Write("\t"); days[16].DisplayDay(); Console.Write("\t"); days[17].DisplayDay(); Console.Write("\t"); days[18].DisplayDay(); Console.Write("\t"); days[19].DisplayDay(); Console.Write("\t"); days[20].DisplayDay(); Console.Write("\t"); days[21].DisplayDay();
                    Console.Write("\n "); days[22].DisplayDay(); Console.Write("\t"); days[23].DisplayDay(); Console.Write("\t"); days[24].DisplayDay(); Console.Write("\t"); days[25].DisplayDay(); Console.Write("\t"); days[26].DisplayDay(); Console.Write("\t"); days[27].DisplayDay(); Console.Write("\t"); days[28].DisplayDay();
                    Console.Write("\n "); days[29].DisplayDay();Console.Write("\t"); days[30].DisplayDay();
                    Console.WriteLine();
                    break;
            }
        }
        Console.ReadLine();
    }


}
