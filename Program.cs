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
        bool userDone = false;
        Boiler boiler = new Boiler(true);

        while (!userDone)
        {
            Console.WriteLine("1. Add Water\n2. Insert Coffee Sort\n3. Make Coffee\n4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:                    
                    espressor.WaterLevelChecker(0);
                    //Console.WriteLine(boiler.ResettingPressure());
                //check pressure in boiler
    
                    break;
                // Other case handling...
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
        
     

