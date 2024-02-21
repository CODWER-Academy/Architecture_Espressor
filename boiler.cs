using Espressor_Components;

namespace Boiler_elements;
public class Boiler{
    
    public int amount;
    private int WaterTemperaute;
    public string PressureStatus;
    

public Boiler() //de schimbat pe protected
{
    //Espressor espressor = new Espressor();
WaterTemperaute = heat_boiler();
//PressureStatus = ResettingPressure();
}

private int heat_boiler(){

   Random rnd = new Random();
    int temperature = rnd.Next(20, 150);
    while(temperature < 90) {
         temperature = rnd.Next(20, 150);//daca e 20, mai repeta ca sa ajunga macar pana la 90
       
    }
    WaterTemperaute = temperature;
    return temperature;
}

public void ResettingPressure(int waterLevel)
{ //esspresorul are capacitate de 150 - 750 ml
    string resetting_pressure;
    amount = waterLevel;
    if(amount > 650 && WaterTemperaute > 95){
        Console.WriteLine("Resetting the pressure in boiler ..."); 
        Thread.Sleep(6000);
        Console.WriteLine("The pressure is normal!");
        //resetting_pressure = "Resetting the pressure in boiler ...";   
    }
    else{
        Console.WriteLine("The pressure is normal"); 
        //resetting_pressure = "The pressure is normal";
    }
    //return resetting_pressure;
        
     
    }
}

