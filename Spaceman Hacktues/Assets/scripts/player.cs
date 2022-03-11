using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : AImovement
{   
    public SpriteRenderer sprite;
    public int PlayerLevel;

    protected override void Start()
    {
        base.Start();
        sprite = GetComponent<SpriteRenderer>();

        DontDestroyOnLoad(gameObject);
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // x and y are -1/0/1 depending on which direction button you are pressing

        UpdateMotor(new Vector3(x, y, 0));
    }
    public void swapsprite()
    {
        this.sprite.sprite = gamemanager.instance.playersprites[gamemanager.instance.characterNum];
    }
}
