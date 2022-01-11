using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class С : MonoBehaviour
{
    public GameObject headPanel;

    public void OnClickPlay()
    {
        if (!headPanel.GetComponent<Animator>().enabled) headPanel.GetComponent<Animator>().enabled = true;
        else headPanel.GetComponent<Animator>().SetTrigger("In");
    }
   
}
