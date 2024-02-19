using System.Security.Cryptography.X509Certificates;

namespace Boiler_elements;
public class Boiler{
    //trebuie sa creez o legature intre niv apei, temp si presiune, dupa care sa incep un proces numit releasePressure(+-) care va elibera presiunea if it is needed
    //!!!in loc de boiler heater, pot adauga methoda heat water care va avea functia sa atinga in 10 secunde temp de 180 de grade, dupa care processul va merge mai departe
    public int WaterLevel; //introduced by user
    private int WaterTemperaute;
    public bool Start_button = false; //by default is false, when this button is pressed by user it becomes true
    public bool IsWaterLevelSufficient => WaterLevelChecker();


public Boiler(int waterLevel, bool StartButton) //de schimbat pe protected
{
WaterTemperaute = heat_boiler();
WaterLevel = waterLevel;
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

public string resetting_pressure()
{ //esspresorul are capacitate de 150 - 750 ml
    string resetting_pressure;
    if(WaterLevel > 650 && WaterTemperaute > 95){
        resetting_pressure = "Resetting the pressure in boiler";
    }
    else{
        resetting_pressure = "The pressure is normal";
    }
    return resetting_pressure;    
    
}
public bool WaterLevelChecker(){
    bool value_level = false;
    if (WaterLevel < 150 || WaterLevel > 750){
        value_level = false; //throw new ArgumentOutOfRangeException(nameof(WaterLevel), "The water level should be equal or greater than 150 ml");
    }
    else{
        value_level = true;
    }
    return value_level;
}




//methoda care transmite DUPA INDEPLINIREA CONDITIILOR apa fierbinte de la boiler la pot
//WaterDeliver(){}

}