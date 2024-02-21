using System;
using Boiler_elements;
using Light_Indicator;
using Pot_Mechanism;
using Espressor_Components;

    public class Program
{
    public static void Main(string[] args)
    {
        Espressor espressor = new Espressor();
        //bool userDone = false;
        Boiler boiler = new Boiler();
        
        while (espressor.StartEspressor())
        {
            Console.WriteLine("1. Add Water\n2. Insert Coffee Sort\n3. Make Coffee\n4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:                    
                    espressor.WaterLevelChecker(0);
                    //Console.WriteLine(boiler.PressureSetting());
                    Console.WriteLine("Choose the next step Insert Coffee Sort.");

                //check pressure in boiler
    
                break;
                case 2:
                 Console.WriteLine("Choose your coffe arabica, robusta, liberica");
                string coffee_sort = Console.ReadLine().ToLower();
    // bool result = myPot.InsertCoffee(coffee);
                    espressor.pot.InsertCoffee(coffee_sort);
                    Console.WriteLine("Choose the next step Make Coffee.");
                break;
                case 3:
                espressor.WaterDeliver();
                break;
                case 4:
                Console.WriteLine("Do you want to turn on the Waiting Regime?");
                string user_answer = Console.ReadLine().ToLower();
                if (user_answer == "yes"){
                    //turn on the waiting regim with heating and so on
                    Console.WriteLine(espressor.heat_pot());
                }
                else
                {
                    Console.WriteLine("You can take your coffee! Bon appetit!");
                }
                break;

                // Other case handling...
                default:
                Console.WriteLine("Choose the option by entering its number from the list bellow");
                break;
            }
        }
    }
}




        
    //check light indicator
        // LightIndicator indicator = new LightIndicator(myBoiler);
        // string lightColor = indicator.UpdateColor();

    //check coffee sort
    // Pot myPot = new Pot();
    // Console.WriteLine("Choose your coffe Arabica, Robusta, Liberica");
    // string coffee = Console.ReadLine().ToLower();
    // bool result = myPot.InsertCoffee(coffee);


    //     Console.WriteLine(lightColor);
    //     Console.WriteLine(pressure);
        
     

