using Boiler_elements;

namespace Espressor_Components;
public class Espressor{
    private Boiler boiler;
    public string pressure_status;
    public int WaterLevel; 
    
//MakeCoffee() 

    public Espressor(){
        boiler = new Boiler(true);//de corectat ca sa primeasca fara argumente
    }

//     public bool AddWater(int amount)
//     {    
//     if (amount < 150 || amount > 750)
//     {
//         Console.WriteLine("The amount should be in range 150 - 750 ml. Try again");
//         return false;
//     }
//     else
//     {
//         WaterLevel = amount;
//         boiler.PressureSetting(WaterLevel);
//         Console.WriteLine("The amount is good. \nChoose the next step Insert Coffee Sort.");
//         return true;
//     }
//     }
// }


 public bool WaterLevelChecker(int amount)
    {
        bool value = false;
        bool firstAttempt = true;

        while(!value){
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
            value = true;
            WaterLevel = amount;
            boiler.PressureSetting(WaterLevel);
            Console.WriteLine("The amount is good. \nChoose the next step Insert Coffee Sort.");

        }
    }
    return value; 
    }
    }


