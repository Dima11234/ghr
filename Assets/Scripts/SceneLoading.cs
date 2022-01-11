using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoading : MonoBehaviour
{
    [Header("Загружаемая сцена")]
    public int Menu;
        [Header("Остальные объекты")]
    public Image loadingImg;
    public Text progressText;

    void Start()
    {
        StartCoroutine(AsyncLoad());
    }
    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Menu);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loadingImg.fillAmount = progress;
            progressText.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
       
    }
}
