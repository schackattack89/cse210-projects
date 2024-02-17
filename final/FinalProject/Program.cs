using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ResetColor();

        List<Calendar> calendarList = new List<Calendar>();
        List<Appointment> appointmentList = new List<Appointment>();
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

                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else if (programMenu.GetMenuSelection() == 2)
            {
                Menu apptsMenu = new Menu("Single Appointment", "Weekly Appointment", "Monthly Appointment");                
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
                    appointmentList.Add(myAppt);
                    programMenu.SetMenuCounter(1);
                    programMenu.ShowMenu();
                }
                else if(apptsMenu.GetMenuSelection()== 2){
                    WeeklyAppointment wkAppt = new WeeklyAppointment();
                    wkAppt.GetUserAppt();
                    foreach(DateTime date in wkAppt.GetWeeklyApptList()){
                        WeeklyAppointment currentAppt = new WeeklyAppointment(date, wkAppt.GetDescription());
                        int myApptMonth = currentAppt.GetDate().Month;
                        int myApptYear = currentAppt.GetDate().Year;
                        
                        bool addCal = false;
                        Calendar calToAdd = new Calendar(myApptMonth, myApptYear);

                        foreach(Calendar cal in calendarList){
                            if(cal.CalendarExists(myApptMonth, myApptYear)){
                                cal._days[currentAppt.GetDate().Day-1] = currentAppt.Schedule(cal);
                                addCal = true;
                            }
                            else{
                                calToAdd._days = calToAdd.PopulateDays(calToAdd.HowManyDays());
                                calToAdd._days[currentAppt.GetDate().Day-1] = currentAppt.Schedule(calToAdd);
                            }
                        }
                        if(!addCal){
                            calendarList.Add(calToAdd);
                        }
                        appointmentList.Add(currentAppt);
                    }
                    programMenu.SetMenuCounter(1);
                    programMenu.ShowMenu();
                }
                else if(apptsMenu.GetMenuSelection()==3){
                    MonthlyAppointment monAppt = new MonthlyAppointment();
                    monAppt.GetUserAppt();
                    foreach(DateTime date in monAppt.GetMonthlyApptList()){
                        WeeklyAppointment currentAppt = new WeeklyAppointment(date, monAppt.GetDescription());
                        int myApptMonth = currentAppt.GetDate().Month;
                        int myApptYear = currentAppt.GetDate().Year;
                        
                        bool addCal = false;
                        Calendar calToAdd = new Calendar(myApptMonth, myApptYear);

                        foreach(Calendar cal in calendarList){
                            if(cal.CalendarExists(myApptMonth, myApptYear)){
                                cal._days[currentAppt.GetDate().Day-1] = currentAppt.Schedule(cal);
                                addCal = true;
                            }
                            else{
                                calToAdd._days = calToAdd.PopulateDays(calToAdd.HowManyDays());
                                calToAdd._days[currentAppt.GetDate().Day-1] = currentAppt.Schedule(calToAdd);
                            }
                        }
                        if(!addCal){
                            calendarList.Add(calToAdd);
                        }
                        appointmentList.Add(currentAppt);
                    }
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
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();
                using(StreamWriter outputFile = new StreamWriter(file)){
                    foreach(Appointment appt in appointmentList){
                        outputFile.WriteLine($"{appt.GetDateString()}|{appt.GetDescription()}");
                    }          
                }
                Console.WriteLine($"Current active calendars have been saved to file {file}.\nPress ENTER to return to main menu...");
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