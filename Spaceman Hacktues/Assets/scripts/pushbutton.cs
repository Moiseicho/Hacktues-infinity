using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushbutton : cancolide
{
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "box")
        {
            Onpush();
        }
    }
    protected virtual void Onpush()
    {
        Debug.Log("Pushed");
    }
}
