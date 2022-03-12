using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : cancolide
{
    public string level;
    public Animator transition;
    public float waittime;
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            StartCoroutine(WaitForTrans());
        }
    }
    IEnumerator WaitForTrans()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(waittime);

        gamemanager.instance.SaveState();
        SceneManager.LoadScene(level);
    }
}
