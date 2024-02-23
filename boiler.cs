using Espressor_Components;

namespace Boiler_elements;
public class Boiler{
    
    public int amount;
    private int WaterTemperaute;
    public string PressureStatus;
    

public Boiler()
{
WaterTemperaute = heat_boiler();

}

private int heat_boiler(){//Heating the water

   Random rnd = new Random();
    int temperature = rnd.Next(20, 150);
    while(temperature < 90) {
         temperature = rnd.Next(20, 150);//The temperature is generated randomly, it has to be at least 90 degrees and maximum 150. 
         //I choosed to generate it randomly, because the pressure has a dependence between temperature and amount of water. Therefore if 
         //I will increase temp with for loop, it will be the same all the time, but I dont need it to be the same.
    }
    WaterTemperaute = temperature;
    return temperature;
}

public void ResettingPressure(int waterLevel)
{ //esspresorul are capacitate de 150 - 750 ml
    string resetting_pressure;
    amount = waterLevel;
    if(amount > 650 && WaterTemperaute > 95){ //if the amount of water is greater than 650 and the temperature is randomly generated to be greater than 95, the pressure
    // has to be resetted
        Console.WriteLine("Resetting the pressure in boiler ..."); 
        Thread.Sleep(6000);
        Console.WriteLine("The pressure is normal!");
        
    }
    else{
        Console.WriteLine("The pressure is normal"); 
       
    }        
     
    }
}

