using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    bool isClicked;
    public void TaskOnClic()
    {

        isClicked = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
            {
                {
                    LevelManager.countUnlockedLevel++;
                }
                SceneManager.LoadScene(1);
            }

        }
    }
}
