using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscene : MonoBehaviour
{
    public string level;
    public void MoveToScene()
    {
        SceneManager.LoadScene(level);
    }
}
