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
            gamemanager.instance.showtext("The cube has been granted the past.", 25, Color.yellow, transform.position, Vector3.up * 30, 2.5f);
        }
    }
}
