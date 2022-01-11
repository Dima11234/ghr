using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Cryptography;
public class LevelManager : MonoBehaviour
{
    public static int countUnlockedLevel = 1;

    [SerializeField]
    Sprite unlockedIcon;

    [SerializeField]
    Sprite lockedIcon;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int numLvl = i + 1;
            transform.GetChild(i).gameObject.name = (i + 1).ToString();
            
            transform.GetChild(i).transform.GetChild(0).GetComponent<Text>().text = (i + 1).ToString();

            if (i < countUnlockedLevel)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = unlockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = lockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
