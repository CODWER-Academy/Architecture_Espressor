//va avea methode de aprindere cand espr e pornit, va avea 3-4 culori de indicatii
//blue - in process, red - too much/little water, yellow - processes are ready
using Boiler_elements;

namespace Light_Indicator;
public class LightIndicator{
    private Boiler _boiler;
    public string Color;
    
    public LightIndicator(Boiler boiler){
        _boiler = boiler;
    }
    // public string UpdateColor(){
    //     if(!_boiler.IsWaterLevelSufficient){
    //         return "Red";
    //     }
    //     else
    //     {
    //         return "Green"; //update and add colors
    //     }
    // }
    

}