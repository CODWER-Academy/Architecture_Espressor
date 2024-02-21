using System.Threading.Tasks.Dataflow;
using Boiler_elements;
using Pot_Mechanism;

namespace Espressor_Components;
public class Espressor{
    private Boiler boiler;
    public Pot pot;
    public string pressure_status;
    public int WaterLevel; 
    private bool WaterStatus = false;
    public int PotTemperature;
    //public bool StartButton = false; //by default is false, when this button is pressed by user it becomes true



    public Espressor(){
        boiler = new Boiler();
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
       bool receptacle_status = pot.ReceptacleStatus;
    if (receptacle_status && WaterStatus)
    {
        Console.WriteLine("The hot water is delivering to the pot...");
        Thread.Sleep(3000);
        Console.WriteLine("Delivered.\nMaking the coffee...");
        Thread.Sleep(6000);
        Console.WriteLine("The coffee is done\n");
        return true;
    }
    else
    {
        Console.WriteLine("An error occures with water delivering, try again.");
        return false;
    }
    }

    public int heat_pot(){
        Random rnd = new Random();
        int temperature = 42;
        for(int i = 42; i < 77; i+= 7 ){
            temperature = i;
            Console.WriteLine("The temperature at the moment is... ");
            Thread.Sleep(3000);
        Console.WriteLine(i);
        
        }
        Console.WriteLine("Constant maintaining this temperature:");
        PotTemperature = temperature;
        Console.WriteLine("Press exit to take out the pot");
        return PotTemperature;
    }
    public bool StartEspressor(){
        Console.WriteLine("To turn on the espressor write start");
        bool value = false;
        while(!value){
        string user_command = Console.ReadLine().ToLower();
       if (user_command != "start"){
        Console.WriteLine("Not a valid command, try again");
        value = false;
       }
    
       else
       {
        value = true;
       }
    }
        return value;
    }
    }

    



//Think about how to use pot and plate heater + plate sensor. Maybe after when coffee is done, 
//deodata to turn on the plate heater to the 50 grade to mantain the tempetature till the user
// wont take out the pot with coffee.
//When the user will press EXTRACT THE POT, in the output will appear: WARNING THE POT IS HOT!. 

//Think how to implement the light:)))