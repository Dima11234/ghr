using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIST : MonoBehaviour
{
    public int I;
    public GameObject[] tasks;
    
    // Start is called before the first frame update
    void Start()
    {
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;
    }

    // Update is called once per frame
   public void Randown()
    {

        StartCoroutine(N());
    }
    IEnumerator N()
    {
        yield return new WaitForSeconds(2);
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;

    }
}
