
using Boiler_elements;
using Pot_Mechanism;

namespace Espressor_Components;
public class Espressor{
    private Boiler boiler;
    public Pot pot;
    public string pressure_status;
    public int WaterLevel; 
    public bool WaterStatus = false;
    public int PotTemperature;
    public bool waterdeliver_status = false;
    
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
            if(!firstAttempt){ //I have written this IF, because in Programm class, zero is a parameter for this method,
            // so without this lines, user's input will never pass the water level checker
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
       if (receptacle_status && WaterStatus) //if the water level is normal and the coffee is inserted, the hot water will be delivered
    {
        Console.WriteLine("The hot water is delivering to the pot...");
        Thread.Sleep(3000);
        Console.WriteLine("Delivered.\nMaking the coffee...");
        Thread.Sleep(6000);
        Console.WriteLine("The coffee is done\n");
        waterdeliver_status = true;
    }
    else
    {
        Console.WriteLine("You have no access to this step. Done the steps above."); //user cant jump from one step to another. He has to do all steps in consecutive order
        waterdeliver_status = false;
    }
    return waterdeliver_status;
    }

    public int heat_pot(){ //start the WAITING REGIME. It heats the coffee till 77 degrees and then mantain the constant temperature, 
    //till user will take out the pot
        Random rnd = new Random();
        int temperature = 35;
        if(waterdeliver_status){
        for(int i = 35; i < 77; i+= 7 ){
            temperature = i;
            Console.WriteLine("The temperature at the moment is... ");
            Thread.Sleep(1500);
        Console.WriteLine(i);
        
        }
        Console.WriteLine($"Constant maintaining this temperature: {temperature}");
        PotTemperature = temperature;
    }
    else{
        Console.WriteLine("You have no access to this step. Done the steps above.");
    }
    return PotTemperature;
    }

    public bool StartEspressor(){ //Start Button
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

    

