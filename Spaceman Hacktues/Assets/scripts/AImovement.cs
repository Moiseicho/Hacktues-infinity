using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AImovement : HP
{
    protected BoxCollider2D boxcollider;
    protected Vector3 movedelta;
    protected Vector3 sizebox;
    public float speed = 1.0f;
    private RaycastHit2D hit;
    protected virtual void Start()
    {
        //Make the boxcollider = to the box colider of the object
        boxcollider = GetComponent<BoxCollider2D>();
        sizebox = new Vector3(boxcollider.size.x - 0.03f ,boxcollider.size.y - 0.05f , 0);
    }

    //Remember to try and make the player its own gamemanager. It will be cool. PS - Past Machu.

    protected virtual void UpdateMotor(Vector3 input)
    {
        // Reset the movedelta
        movedelta = input;

        // Swap sprite direction, going right or left
        if(movedelta.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }else if(movedelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        hit = Physics2D.BoxCast(transform.position, sizebox, 0, new Vector2(0, movedelta.y), Mathf.Abs(movedelta.y * Time.deltaTime * speed), LayerMask.GetMask("PC", "Blocking"));
        if(hit.collider == null)
        {
            //make player move y
            transform.Translate(0, movedelta.y * Time.deltaTime * speed, 0);
        }
        hit = Physics2D.BoxCast(transform.position, sizebox, 0, new Vector2(movedelta.x, 0), Mathf.Abs(movedelta.x * Time.deltaTime * speed), LayerMask.GetMask("PC", "Blocking"));
        if(hit.collider == null)
        {
            //make player move x
            transform.Translate(movedelta.x * Time.deltaTime * speed, 0, 0);
        }
    }
}
