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
        bool isRunning = true;
        Boiler boiler = new Boiler();
        if(!espressor.StartEspressor()){
            Console.WriteLine("Not a valid input, try again ");
            return;
        }
        
        while (isRunning)
        {
            Console.WriteLine("1. Add Water\n2. Insert Coffee Sort\n3. Make Coffee\n4. Waiting regime\n5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:                    
                    espressor.WaterLevelChecker(0);
                    Console.WriteLine("Choose the next step Insert Coffee Sort.");

                //check pressure in boiler
    
                break;
                case 2:
                    if(espressor.WaterStatus){                
                    Console.WriteLine("Choose your coffe arabica, robusta, liberica");
                    string coffee_sort = Console.ReadLine().ToLower();
                    espressor.pot.InsertCoffee(coffee_sort);
                    Console.WriteLine("Choose the next step Make Coffee.");
                    }
                    else
                    {
                    Console.WriteLine("You have no access to this step. Done the steps above.");
                    }
                    
                break;
                case 3:
                espressor.WaterDeliver();
                break;
                case 4:
                    espressor.heat_pot();
                break;
                case 5:
                break;

                default:
                Console.WriteLine("Choose the option by entering its number from the list bellow");
                break;
            }
        }
    }
}


