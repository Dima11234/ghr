using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Monetization;

public class Ads : MonoBehaviour
{
    [System.Obsolete]
    void Awake()
    {
        if (Monetization.isSupported) Monetization.Initialize("3963827", false);
    }


    public void RV()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowReslt;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    void HandleShowReslt(ShowResult result)
    {
        if (result == ShowResult.Finished)
            print("Ads finished");
    }
}
