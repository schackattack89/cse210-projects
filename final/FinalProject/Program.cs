using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ResetColor();

        List<Calendar> calendarList = new List<Calendar>();
        Calendar baseCal = new Calendar(1, 2000);
        calendarList.Add(baseCal);

        Menu programMenu = new Menu();
        programMenu.ShowMenu();
        while (programMenu.GetMenuSelection() != 5)
        {
            if (programMenu.GetMenuSelection() == 1)
            {
                Console.Write("Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month: ");
                string monthString = Console.ReadLine();
                int monthNum = Convert.ToDateTime(monthString + "01, 1900").Month;
                Calendar testCal = new Calendar(monthNum, year);
                int noMatch = 0;
                foreach (Calendar calendarChoice in calendarList)
                {
                    if ((calendarChoice.GetMonthNum() == monthNum) && (calendarChoice.GetYear() == year))
                    {
                        calendarChoice.drawCalendar(calendarChoice.HowManyDays(), calendarChoice.PopulateDays(calendarChoice.HowManyDays()));
                    }
                    else
                    {
                       noMatch ++;
                    }
                }
                if(noMatch == calendarList.Count){
                    Console.WriteLine($"You have 0 appointments for {monthString} {year}");
                    Console.WriteLine("Press ENTER to continue...");
                    Console.ReadLine();
                }
                // Calendar myCal = new Calendar(monthNum, year);
                // int monthLength = myCal.HowManyDays();
                // List<Day> dayList = myCal.PopulateDays(monthLength);
                // myCal.drawCalendar(monthLength, dayList);
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else if (programMenu.GetMenuSelection() == 2)
            {
                Menu apptsMenu = new Menu("Single Appointment", "Weekly Appointment", "Monthly Appointment");
                // ApptScheduler myAppointment = new ApptScheduler();
                
                apptsMenu.ShowMenu();
                if(apptsMenu.GetMenuSelection()==1){
                    SingleAppointment myAppt = new SingleAppointment();
                    
                    myAppt.GetUserAppt();
                    
                    int myApptMonth = myAppt.GetDate().Month;
                    int myApptYear = myAppt.GetDate().Year;
                    
                    bool addCal = false;
                    Calendar calToAdd = new Calendar(myApptMonth, myApptYear);

                    foreach(Calendar cal in calendarList){
                        if(cal.CalendarExists(myApptMonth, myApptYear)){
                            cal._days[myAppt.GetDate().Day-1] = myAppt.Schedule(cal);
                            addCal = true;
                        }
                        else{
                            calToAdd._days = calToAdd.PopulateDays(calToAdd.HowManyDays());
                            calToAdd._days[myAppt.GetDate().Day-1] = myAppt.Schedule(calToAdd);
                        }
                    }
                    if(!addCal){
                        calendarList.Add(calToAdd);
                    }
                    
                    programMenu.SetMenuCounter(1);
                    programMenu.ShowMenu();
                }
                else if(apptsMenu.GetMenuSelection()== 2){
                    WeeklyAppointment wkAppt = new WeeklyAppointment();
                    wkAppt.GetUserAppt();
                    
                    int myApptMonth = wkAppt.GetDate().Month;
                    int myApptYear = wkAppt.GetDate().Year;
                    
                    bool addCal = false;
                    Calendar calToAdd = new Calendar(myApptMonth, myApptYear);

                    foreach(Calendar cal in calendarList){
                        if(cal.CalendarExists(myApptMonth, myApptYear)){
                            cal._days[wkAppt.GetDate().Day-1] = wkAppt.Schedule(cal);
                            addCal = true;
                        }
                        else{
                            calToAdd._days = calToAdd.PopulateDays(calToAdd.HowManyDays());
                            calToAdd._days[wkAppt.GetDate().Day-1] = wkAppt.Schedule(calToAdd);
                        }
                    }
                    if(!addCal){
                        calendarList.Add(calToAdd);
                    }
                    
                    programMenu.SetMenuCounter(1);
                    programMenu.ShowMenu();
                }
                else if(apptsMenu.GetMenuSelection()==3){
                    MonthlyAppointment monAppt = new MonthlyAppointment();
                    monAppt.GetUserAppt();

                    //monAppt.Schedule();
                    programMenu.SetMenuCounter(1);
                    programMenu.ShowMenu();
                }
                else{
                        programMenu.SetMenuCounter(1);
                        programMenu.ShowMenu();
                }
            }
            else if (programMenu.GetMenuSelection() ==3)
            {
                Console.WriteLine("HELLO!!!!");
                Console.ReadLine();
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else if (programMenu.GetMenuSelection() == 4)
            {
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else
            {
                System.Environment.Exit(1);
            }

        }
    }
    //public 
}