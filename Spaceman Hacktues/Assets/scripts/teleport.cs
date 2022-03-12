using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : cancolide
{
    public string level;
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            gamemanager.instance.SaveState();
            SceneManager.LoadScene(level);
        }
    }
}
