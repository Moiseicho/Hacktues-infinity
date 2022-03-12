using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovewallsPButton : pushbutton
{
    public GameObject WalsDest;
    protected override void Onpush()
    {
       WalsDest.SetActive(false);
       Debug.Log("Shown");
    }
}
