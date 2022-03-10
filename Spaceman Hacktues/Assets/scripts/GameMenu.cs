using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour
{
    //Text
    //public Text HPTxt, HPMaxTxt, levelTxt, monsTxt, EXPTxt, upcostTxt;

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
        
    }
}
