using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : AImovement
{   
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // x and y are -1/0/1 depending on which direction button you are pressing

        UpdateMotor(new Vector3(x, y, 0));
    }
}
