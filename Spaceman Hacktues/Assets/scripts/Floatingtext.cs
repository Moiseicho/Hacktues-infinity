using UnityEngine;
using UnityEngine.UI;

public class Floatingtext
{
    // Start is called before the first frame update
    public bool active;
    public GameObject refr;
    public Text text;
    public Vector3 Motion;
    public float duration;
    public float timed;
    
    public void show()
    {

        active = true;
        timed = Time.time;
        refr.SetActive(active);

    }

    public void hide()
    {
        
        active = false;
        refr.SetActive(active);

    }

    public void UpdatenotM()
    {

        if(!active)
        {
            return;
        }

        if(Time.time - timed > duration)
        {
            hide();
            return;
        }

        refr.transform.position += Motion * Time.deltaTime;
    }

}
