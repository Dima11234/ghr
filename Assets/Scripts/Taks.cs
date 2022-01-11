using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Taks : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string Task;
    public string Answers;
    public Text Tesk;
    public List<Text> t;
     int i = 0;

    
    public string True;
    // Start is called before the first frame update
    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        Task = s[0];
        Answers = s[1];
        True = s[2];
        Tesk.text = Task;
        string[] A = Answers.Split(';');

        while(i<4)
        {
            int f = Random.Range(0, t.Count);
            t[f].text = A[i];
            t.RemoveAt(f);
            i ++;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
