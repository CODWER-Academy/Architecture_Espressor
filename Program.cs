using System;
using Boiler_elements;
using Light_Indicator;
using Pot_Mechanism;
    public class Program
    {
        //check pressure in boiler
        public static void Main(string[] args){
        Boiler myBoiler = new Boiler(180, false);
        string pressure = myBoiler.resetting_pressure();

    //check light indicator
        LightIndicator indicator = new LightIndicator(myBoiler);
        string lightColor = indicator.UpdateColor();

    //check coffee sort
    Pot myPot = new Pot();
    Console.WriteLine("Choose your coffe Arabica, Robusta, Liberica");
    string coffee = Console.ReadLine().ToLower();
    bool result = myPot.InsertCoffee(coffee);


        Console.WriteLine(lightColor);
        Console.WriteLine(pressure);
        
        }

    }

