using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U : MonoBehaviour
{
    public int Score = 0;
    public GameObject ScoreText;

    public void Count()
    {
        Score++;
        ScoreText.GetComponent<Text>().text = "Очки:" + Score.ToString();
    }

}
