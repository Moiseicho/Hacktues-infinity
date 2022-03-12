using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FTManager : MonoBehaviour
{
    public GameObject textbox;
    public GameObject textpf;

    private List<Floatingtext> Texts = new List<Floatingtext>();  
    public void Show(string stext, int fonts, Color fontc, Vector3 Pos, Vector3 motion, float duration)
    {
        Floatingtext obj = GetFloatingtext();

        obj.text.text = stext;
        obj.text.fontSize = fonts;
        obj.text.color = fontc;
        obj.refr.transform.position = Camera.main.WorldToScreenPoint(Pos);
        obj.Motion = motion;
        obj.duration = duration;

        obj.show();
        
    }

    private void Update()
    {
        foreach(Floatingtext txt in Texts)
        {
            txt.UpdatenotM();
        }

    }
    private Floatingtext GetFloatingtext()
    {
        Floatingtext gettxt = Texts.Find(t => !t.active);
        
        if(gettxt == null)
        {
            gettxt = new Floatingtext();
            gettxt.refr = Instantiate(textpf);
            gettxt.refr.transform.SetParent(textbox.transform); 
            gettxt.text = gettxt.refr.GetComponent<Text>();

            Texts.Add(gettxt);
        }

        return gettxt;
    }

}
