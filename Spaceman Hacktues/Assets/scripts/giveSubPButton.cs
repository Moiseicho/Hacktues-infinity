using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveSubPButton : pushbutton
{
    public GameObject animated;
    protected override void Onpush()
    {
       GetComponent<BoxCollider2D>().enabled = false;
       animated.GetComponent<Animator>().SetTrigger("apear");
       Debug.Log("Shown");
    }
}
