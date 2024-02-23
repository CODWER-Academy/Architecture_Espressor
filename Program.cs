using System;
using Boiler_elements;

using Espressor_Components;
public class Program
{
    public static void Main(string[] args)
    {
        Espressor espressor = new Espressor();
        bool isRunning = true;
        Boiler boiler = new Boiler();
      
        espressor.StartEspressor(); //porneste espressorul

        List<string> steps = new List<string>()
        {
            "1. Add Water",
            "2. Insert Coffee Sort",
            "3. Make Coffee",
            "4. Waiting regime",
            "5. Exit"
        }; //lista creata pentru a sterge conditia pasilor deja realizati in output
        
        while (isRunning)
        {
            foreach (var step in steps)
            {
                Console.WriteLine(step);
            }
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    espressor.WaterLevelChecker(0); //Verifica daca nivelul apei este in range 150ml - 750ml
                    steps.RemoveAt(0); // Remove "Add Water" step
                    break;
                case "2":
                    if (espressor.WaterStatus)
                    {
                        Console.WriteLine("Choose your coffee arabica, robusta, liberica");
                        string coffee_sort = Console.ReadLine().ToLower();
                        espressor.pot.InsertCoffee(coffee_sort);
                        if(espressor.pot.ReceptacleStatus){ //Inserteaza cafeaua
                        steps.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have no access to this step. Done the steps above."); //Userul NU poate sari de la start la pasul 2. Pasii se indeplinesc consecutiv
                    }
                    break;
                case "3":
                    espressor.WaterDeliver();
                    steps.RemoveAt(0);
                    break;
                case "4":
                    espressor.heat_pot();
                    steps.RemoveAt(0); 
                    break;
                case "5":
                    Console.WriteLine("Bon appetit!!!");
                    isRunning = false; //Turn off the espressor
                    break;
                default:
                    Console.WriteLine("Choose the option by entering its number from the list below");
                    break;
            }
        }
    }
}
