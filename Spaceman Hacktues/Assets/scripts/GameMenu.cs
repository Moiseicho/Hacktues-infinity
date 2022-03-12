using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour
{
    //Text
    public Text massTxt, diameterTxt, densetyTxt, DistanceFromSunTxt, NumberOfMoonsTxt, gravityTxt, LengthOfDayTxt, SurfacePressureTxt, NameTxt;

    public planet planets;
    //Logic
    public Image characterSprite;
    public void OnArrowClick(bool right)
    {
        if(right)
        {
            gamemanager.instance.characterNum++;
            if(gamemanager.instance.characterNum == gamemanager.instance.playersprites.Count)
            {
                gamemanager.instance.characterNum = 0;
            }
            changeCharacter();
        }
        else
        {
            gamemanager.instance.characterNum--;
            if(gamemanager.instance.characterNum<0)
            {
                gamemanager.instance.characterNum = gamemanager.instance.playersprites.Count-1;
            }
            changeCharacter();
        }
    } 
    private void changeCharacter()
    {
        characterSprite.sprite = gamemanager.instance.playersprites[gamemanager.instance.characterNum];
        gamemanager.instance.player.swapsprite();
    }
    public void updateMenu()
    {
        changeCharacter();
        Debug.Log("Its stupid");
        massTxt.text ="Mass: " + planets.mass + " TeraTons.";
        diameterTxt.text ="Diameter: " + planets.diameter.ToString() + " km.";
        densetyTxt.text ="Densety: " + planets.densety.ToString() + " kg/m^3.";
        DistanceFromSunTxt.text ="Distance to sun: " + planets.DistanceFromSun.ToString() + " km.";
        NumberOfMoonsTxt.text ="Number of moons: " + planets.NumberOfMoons.ToString() + ".";
        gravityTxt.text ="Gravitational pull: " + planets.gravity.ToString() + " g.";
        LengthOfDayTxt.text ="Length of day: " + planets.LengthOfDay.ToString() + " h.";
        SurfacePressureTxt.text ="Surface pressure: " + planets.SurfacePressure.ToString() + " bar.";
        NameTxt.text = "Name:" + planets.Name + ".";
    }
}
