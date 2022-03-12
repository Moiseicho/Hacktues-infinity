using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : AImovement
{   
    public SpriteRenderer sprite;
    public int PlayerLevel;
    public Animator animator;
    
    //Vector2 movement;

    protected override void Start()
    {
        base.Start();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        swapsprite();

        DontDestroyOnLoad(gameObject);
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // x and y are -1/0/1 depending on which direction button you are pressing
        if(x == 0 && y == 0){
            animator.SetFloat("Speed", 0);
        }
        else{
            animator.SetFloat("Speed", 1);
            animator.SetFloat("Horizontal", x);
            animator.SetFloat("Vertical", y);
        }
        UpdateMotor(new Vector3(x, y, 0));
        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);

        
        
    }
    public void swapsprite()
    {
        this.sprite.sprite = gamemanager.instance.playersprites[gamemanager.instance.characterNum];
    }
}
