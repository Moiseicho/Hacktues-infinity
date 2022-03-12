using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : cancolide
{
    protected bool collected;

    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            Oncollect();
        }
    }

    protected virtual void Oncollect()
    {
        collected = true;
    }
}
