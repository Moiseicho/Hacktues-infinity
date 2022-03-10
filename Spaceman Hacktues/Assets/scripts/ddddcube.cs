using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddddcube : collectable
{

    public Sprite emptychest;
    public GameObject linkedbutton;
    protected override void Oncollect()
    {
        if(!collected){
            linkedbutton.SetActive(true);
            collected = true;
            gamemanager.instance.CubeCount++;
            GetComponent<SpriteRenderer>().sprite = emptychest;
            gamemanager.instance.showtext("The penis has been granted 2", 25, Color.yellow, transform.position, Vector3.up * 30, 2.5f);
        }
    }
}
