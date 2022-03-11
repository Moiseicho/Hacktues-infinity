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

        //PlayerPrefs.DeleteAll();
        Debug.Log("Working?");
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    public void Deletesafe()
    {
        PlayerPrefs.DeleteAll();
    }

    //Ressources    
    public List<Sprite> playersprites;
    public int CubeCount;
    public int characterNum;
    //Refrences
    public player player;
    public FTManager Ftm;
    //Logic
    public int Boxcount;

    public void showtext(string stext, int fonts, Color fontc, Vector3 Pos, Vector3 motion, float duration)
    {
        Ftm.Show(stext,fonts,fontc,Pos,motion,duration);
    }
        public void SaveState()
    {
        string s = "";
        s += Boxcount.ToString() + "|";
        s += characterNum.ToString(); //0|75|10|0

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
        Boxcount = int.Parse(data[0]);
        characterNum = int.Parse(data[1]);
        Debug.Log("Loaded");
        player.transform.position = GameObject.Find("spawnpoint").transform.position;
    }
}
