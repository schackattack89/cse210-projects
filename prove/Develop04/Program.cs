using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Menu programMenu = new Menu();
        programMenu.ShowMenu();
        while(programMenu.GetMenuSelection()!=5){
            if(programMenu.GetMenuSelection() == 1){
                BreathingActivity active = new BreathingActivity();
                active.Run();
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            } 
            else if(programMenu.GetMenuSelection() == 2){
                ReflectingActivity active = new ReflectingActivity();
                active.Run();
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else if(programMenu.GetMenuSelection() == 3){
                ListingActivity active = new ListingActivity();
                active.Run();
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else if(programMenu.GetMenuSelection() == 4){
                Activity active = new Activity();
                active.viewLog();
                programMenu.SetMenuCounter(1);
                programMenu.ShowMenu();
            }
            else{
                System.Environment.Exit(1);
            }
        }
    }
}