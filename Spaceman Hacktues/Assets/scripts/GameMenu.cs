using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour
{
    //Text
    public Text massTxt, diameterTxt, densetyTxt, DistanceFromSunTxt, NumberOfMoonsTxt, gravityTxt, LengthOfDayTxt, SurfacePressureTxt, NameTxt;

    //Logic
    private int characterNum;
    public Image characterSprite;
    public void OnArrowClick(bool right)
    {
        if(right)
        {
            characterNum++;
            if(characterNum == gamemanager.instance.playersprites.Count)
            {
                characterNum = 0;
            }
            changeCharacter();
        }
        else
        {
            characterNum--;
            if(characterNum<0)
            {
                characterNum = gamemanager.instance.playersprites.Count-1;
            }
            changeCharacter();
        }
    } 
    private void changeCharacter()
    {
        characterSprite.sprite = gamemanager.instance.playersprites[characterNum];
        gamemanager.instance.player.swapsprite(characterNum);
    }
    public void updateMenu()
    {
        Debug.Log("Its stupid");
        int planetnum = gamemanager.instance.planetnum;
        massTxt.text ="Mass: " + gamemanager.instance.planets[planetnum].mass.ToString() + " TeraTons.";
        diameterTxt.text ="Diameter: " + gamemanager.instance.planets[planetnum].diameter.ToString() + " km.";
        densetyTxt.text ="Densety: " + gamemanager.instance.planets[planetnum].densety.ToString() + " kg/m^3.";
        DistanceFromSunTxt.text ="Distance to sun: " + gamemanager.instance.planets[planetnum].DistanceFromSun.ToString() + " km.";
        NumberOfMoonsTxt.text ="Number of moons: " + gamemanager.instance.planets[planetnum].NumberOfMoons.ToString() + ".";
        gravityTxt.text ="Gravitational pull: " + gamemanager.instance.planets[planetnum].gravity.ToString() + " g.";
        LengthOfDayTxt.text ="Length of day: " + gamemanager.instance.planets[planetnum].LengthOfDay.ToString() + " h.";
        SurfacePressureTxt.text ="Surface pressure: " + gamemanager.instance.planets[planetnum].SurfacePressure.ToString() + " bar.";
        NameTxt.text = "Name:" + gamemanager.instance.planets[planetnum].Name + ".";
    }
}
