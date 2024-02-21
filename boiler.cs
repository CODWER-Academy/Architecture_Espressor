using System.Security.Cryptography.X509Certificates;
using Espressor_Components;

namespace Boiler_elements;
public class Boiler{
    
    public int amount;
    private int WaterTemperaute;
    public string PressureStatus;
    public bool Start_button = false; //by default is false, when this button is pressed by user it becomes true
    

public Boiler(bool StartButton) //de schimbat pe protected
{
    //Espressor espressor = new Espressor();
WaterTemperaute = heat_boiler();
PressureStatus = ResettingPressure();

StartButton = Start_button;
}

private int heat_boiler(){

   Random rnd = new Random();
    int temperature = rnd.Next(20, 120);
    while(temperature < 90) {
         temperature = rnd.Next(20, 120);//daca e 20, mai repeta ca sa ajunga macar pana la 90
       
    }
    WaterTemperaute = temperature;
    return temperature;
}
//Espressor WaterLevel = amount;


public void PressureSetting(int waterLevel)
    {
        // Set the amount based on waterLevel received from Espressor
        this.amount = waterLevel;
        PressureStatus = ResettingPressure();
    }
public string ResettingPressure()
{ //esspresorul are capacitate de 150 - 750 ml
    string resetting_pressure;
    if(amount > 650 && WaterTemperaute > 95){
        resetting_pressure = "Resetting the pressure in boiler";
    }
    else{
        resetting_pressure = "The pressure is normal";
    }
    return resetting_pressure;    
    

}




//methoda care transmite DUPA INDEPLINIREA CONDITIILOR apa fierbinte de la boiler la pot
//WaterDeliver(){}

}