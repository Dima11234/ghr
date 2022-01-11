using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttonsMenu;
    public GameObject buttonsExit;
    void Start()
    {

        {

        }

        
        {

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowExitButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }
    public void BackInMenu()
    {
        buttonsMenu.SetActive(true);
        buttonsExit.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
