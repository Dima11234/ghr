using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class NewADS : MonoBehaviour
{
    [SerializeField] private bool _testMode = true;
    private string _gameId = "4368049";
    private string _video = "Interstitial_Android";
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(_gameId, _testMode);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void ShowAdsVideo(string placementId)
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show(placementId);
        }
        else
        {
            Debug.Log("Advertisement not ready!");
        }
    }
}
