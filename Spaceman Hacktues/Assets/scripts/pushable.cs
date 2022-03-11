using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushable : cancolide
{
    public float startposx, startposy;
    public float boundxp=3f, boundyp=0.05f, boundxm = 0.05f, boundym = 2f;

    protected override void Start()
    {
        base.Start();
        startposx = gameObject.transform.position.x;
        startposy = gameObject.transform.position.y;
    }
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            Debug.Log(2*gameObject.transform.position.y - coll.transform.position.y - startposy);
            float pushforse = 0.05f;
            if(2*gameObject.transform.position.x - coll.transform.position.x - startposx <= boundxp && 2*gameObject.transform.position.x - coll.transform.position.x - startposx >= boundxm)
                gameObject.transform.Translate(pushforse*( gameObject.transform.position.x - coll.transform.position.x), 0, 0); 
            if(2*gameObject.transform.position.y - coll.transform.position.y - startposy <= boundyp && 2*gameObject.transform.position.y - coll.transform.position.y - startposy >= boundym)
                gameObject.transform.Translate(0, pushforse*( gameObject.transform.position.y - coll.transform.position.y), 0); 
        }
    }
}
