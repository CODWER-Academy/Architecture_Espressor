//Not implemented light signals, because I thought it would be more clear to use textual explanations. In case the espressor will have a graphical representation, 
//i will use the light indicator :)
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