using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Pot_Mechanism;
public class Pot{
//obiect PlateHeater care incalzeste pana la o temp anumita si cand cana e luata, el se opreste (1 sau 2 metode)

//public bool Plate_sensor = false; //by default is false, when the coffee is poured in the pot it becomes true
public readonly List<String> Receptacle = new List<String>(3)
{
    "arabica", "liberica", "robusta"
}; 
public bool ReceptacleStatus;
//user has 3 variants of coffee sorts "arabica", "liberica", "robusta" 
//receptacle va avea metoda insert coffee (userul va alege din cele 3 sorturi)
public Pot()
{

}

public bool InsertCoffee(string coffeeSort)
{
    Console.WriteLine("Inserting the coffee...");
    Thread.Sleep(3000);
    if(Receptacle.Contains(coffeeSort))
    {
    Console.WriteLine($"{coffeeSort} has been successfully insterted");
    ReceptacleStatus = true;
}
else
{
    Console.WriteLine("Invalid coffee sort. Please insert Arabica Liberica or Robusta");
    ReceptacleStatus = false;
}
return ReceptacleStatus;

}



}