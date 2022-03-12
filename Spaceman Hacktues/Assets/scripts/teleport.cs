using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : cancolide
{
    public string level;
    public float time;
    public Animator animator;
    protected override void Oncollide(Collider2D coll)
    {
        if(coll.name == "player")
        {
            StartCoroutine(DoTransition());
        }
    }
    IEnumerator DoTransition()
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(time);

        gamemanager.instance.SaveState();
        SceneManager.LoadScene(level);
    }
}
