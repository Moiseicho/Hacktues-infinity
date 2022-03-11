using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushable : cancolide
{
    Vector3 pushdir;
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            float pushforse = 0.05f;
            gameObject.transform.Translate(pushforse*( gameObject.transform.position.x - coll.transform.position.x), pushforse*( gameObject.transform.position.y - coll.transform.position.y), 0); 
        }
    }
}
