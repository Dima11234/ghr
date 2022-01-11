using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BTN_TXT : MonoBehaviour
{
    public GameObject VPR;
    public Color gr;
    public Color f1;
    public Image th;
    public Text t;
    public Taks task;
    public True tru;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Check()
    {
       
        if (t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
            tru.Score = tru.Score + 1;

        }
        else
        {
            th.color = f1;
            StartCoroutine(Wait());

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        VPR.active = false;
    }
}
