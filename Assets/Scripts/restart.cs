using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
  
    public void RestartLevel()
    {
        SceneManager.LoadScene("1_Level");
    }
    public void RestartLevel2()
    {
        SceneManager.LoadScene("2.1_Level");
    }
    public void RestartLevel3()
    {
        SceneManager.LoadScene("3.2_Level");
    }
   
}
