using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public float timeStart = 10f;
    public Text Timer;
    public GameObject game;
    public GameObject timeUp;
    public GameObject lose;
    public GameObject win;

    bool isWin = false;
    bool isLose = false;


    // Start is called before the first frame update
    void Start()
    {
        Timer.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart > 0 && !isLose&& !isWin)
        {
            timeStart -= Time.deltaTime;
            Timer.text = Mathf.Round(timeStart).ToString();
        }
        else if (!isLose && !isWin)
        {
            game.SetActive(false);
            timeUp.SetActive(true);
        }
        else if (isLose)
        {
            game.SetActive(false);
            lose.SetActive(true);
        }
        else
        {
            game.SetActive(false);
            win.SetActive(true);
        }
    }
    public void WrongAns()
    {
        isLose = true;

    }
        public void RightAns()
        {
            isWin = true;
        }


}
