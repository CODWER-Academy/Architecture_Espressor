using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Espressor_Components;

namespace Pot_Mechanism;
public class Pot{

public readonly List<String> Receptacle = new List<String>(3)
{
    "arabica", "liberica", "robusta"
}; 
public bool ReceptacleStatus;
//user has 3 variants of coffee sorts "arabica", "liberica", "robusta" 
public Pot()
{
}

public bool InsertCoffee(string coffeeSort)
{
    Console.WriteLine("Inserting the coffee...");
    Thread.Sleep(3000);
        if(Receptacle.Contains(coffeeSort)) //Verify if user's input is correct
        {
        Console.WriteLine($"{coffeeSort} has been successfully insterted");
        ReceptacleStatus = true;
        Console.WriteLine("Choose the next step Make Coffee.");
        }
        else
        {
        Console.WriteLine("Invalid coffee sort. Please insert Arabica Liberica or Robusta");
        ReceptacleStatus = false;   
        }

        return ReceptacleStatus;
}



}