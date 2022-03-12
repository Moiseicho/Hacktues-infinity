using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    private void Awake()
    {
        if(gamemanager.instance != null){
            Destroy(gameObject);
            return;
        }

        PlayerPrefs.DeleteAll();
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Ressources    
    public List<Sprite> playersprites;
    public List<int> cubeslist;

    //Refrences
    public player player;
    public FTManager Ftm;


    //Logic
    public int cube;

    public void showtext(string stext, int fonts, Color fontc, Vector3 Pos, Vector3 motion, float duration)
    {
        Ftm.Show(stext,fonts,fontc,Pos,motion,duration);
    }

    public void SaveState()
    {
        string s = "";
        s += "0" + "|";
        s += cube.ToString() + "|";
        s += "0"; //0|2|0

        PlayerPrefs.SetString("Save", s);
        Debug.Log("Saved");
    }

    public void LoadState(Scene scene, LoadSceneMode mode)
    {
        if(!PlayerPrefs.HasKey("Save"))
        {
            return;
        }
        string[] data = PlayerPrefs.GetString("Save").Split('|');
        cube = int.Parse(data[1]);
        Debug.Log("Loaded");
    }
}
