using Boiler_elements;
using Pot_Mechanism;

namespace Espressor_Components;
public class Espressor{
    private Boiler boiler;
    public Pot pot;
    public string pressure_status;
    public int WaterLevel; 
    //private bool ReceptacleStatus;
    private bool WaterStatus = false;
    public bool receptacle_status;
    
//MakeCoffee() 

    public Espressor(){
        boiler = new Boiler(true);//de corectat ca sa primeasca fara argumente
        pot = new Pot();
    }



 public bool WaterLevelChecker(int amount)
    {
        
        bool firstAttempt = true;

        while(!WaterStatus){
        if (amount < 150 || amount > 750)
        {
            if(!firstAttempt){
                Console.WriteLine("The amount should be in range 150 - 750 ml. try again!!!");

            }
            //value = false;
            Console.WriteLine("Enter the amount of water in ml (150 - 750): ");
            amount = Convert.ToInt32(Console.ReadLine());
            firstAttempt = false;
        }
        else
        {
            WaterStatus = true;
            WaterLevel = amount;
            Console.WriteLine("The amount is good."); 
            boiler.ResettingPressure(amount);
            
            
        }
    }
    return WaterStatus; 
    }

    public bool WaterDeliver(){
        receptacle_status = pot.ReceptacleStatus;
    if (receptacle_status && WaterStatus)
    {
        Console.WriteLine("The hot water is delivering to the pot...");
        Thread.Sleep(6000);
        Console.WriteLine("Delivered");

        return true;
    }
    else
    {
        Console.WriteLine("An error occures with water delivering, try again.");
        return false;
    }
    }
    }


//Think about how to use pot and plate heater + plate sensor. Maybe after when coffee is done, 
//deodata to turn on the plate heater to the 50 grade to mantain the tempetature till the user
// wont take out the pot with coffee.
//When the user will press EXTRACT THE POT, in the output will appear: WARNING THE POT IS HOT!. 

//Think how to implement the light:)))