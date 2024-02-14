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
        switch (programMenu.GetMenuSelection())
        {
            case "1":
                Console.Write("Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month: ");
                string monthString = Console.ReadLine();
                int monthNum = Convert.ToDateTime(monthString + "01, 1900").Month;
                foreach(Calendar calendarChoice in calendarList){
                    if((calendarChoice.GetMonthNum()==monthNum)&&(calendarChoice.GetYear()==year)){
                        calendarChoice.drawCalendar(calendarChoice.HowManyDays(), calendarChoice.PopulateDays(calendarChoice.HowManyDays()));
                    }
                    else{
                        Console.WriteLine($"You have 0 appointments for {monthString} {year}");
                        Console.WriteLine("Press ENTER to continue...");
                        Console.ReadLine();
                    }
                }
                // Calendar myCal = new Calendar(monthNum, year);
                // int monthLength = myCal.HowManyDays();
                // List<Day> dayList = myCal.PopulateDays(monthLength);
                // myCal.drawCalendar(monthLength, dayList);
                programMenu.ShowMenu();
                break;
            case "2":
                Menu apptsMenu = new Menu("Single Appointment", "Weekly Appointment", "Monthly Appointment");
                ApptScheduler myAppointment = new ApptScheduler();
                apptsMenu.ShowMenu();
                switch(apptsMenu.GetMenuSelection())
                {
                    case "1":
                        SingleAppointment appt1 = new SingleAppointment(myAppointment.GetUserAppt());
                        
                        Calendar thisCal = appt1.Schedule();
                        calendarList.Add(thisCal);
                        programMenu.ShowMenu();
                        break;
                    case "2":
                        WeeklyAppointment appt2 = new WeeklyAppointment(myAppointment.GetUserAppt());
                        appt2.Schedule();
                        programMenu.ShowMenu();
                        break;
                    case "3":
                        MonthlyAppointment appt3 = new MonthlyAppointment(myAppointment.GetUserAppt());
                        appt3.Schedule();
                        programMenu.ShowMenu();
                        break;
                    default:
                        programMenu.ShowMenu();
                        break;;
                }
                break;
            case "3":
                Console.WriteLine("HELLO!!!!");
                Console.ReadLine();
                // programMenu.SetMenuCounter(1);
                // programMenu.ShowMenu();
                break;
            case "4":
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
                break;
            default:
                System.Environment.Exit(1);
                break;
        }

    }
}