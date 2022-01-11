using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour
{
    public GameObject lvlsound;

    // Use this for initialization
    void Start()
    {
        var lvlsoundGO = GameObject.Find("lvlsound");
        if (lvlsound == null)
        {
            lvlsound = Instantiate(lvlsound);
            lvlsound.name = "lvlsound";
        }
        DontDestroyOnLoad(lvlsoundGO);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


