using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramoove : MonoBehaviour
{
    private Transform lockobj;
    public float boundx=0.25f;
    public float boundy=0.1f;
    private void Start()
    {
        lockobj = GameObject.Find("player").transform;
    }
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float deltax = lockobj.position.x - transform.position.x;
        float deltay = lockobj.position.y - transform.position.y;

        if(deltax >= boundx || deltax <= -boundx)
        {
            if(transform.position.x < lockobj.position.x){
                delta.x = deltax - boundx;
            }else
            {
                delta.x = deltax + boundx;
            }
        }

        if(deltay >= boundy || deltay <= -boundy)
        {
            if(transform.position.y < lockobj.position.y){
                delta.y = deltay - boundy;
            }else
            {
                delta.y = deltay + boundy;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
