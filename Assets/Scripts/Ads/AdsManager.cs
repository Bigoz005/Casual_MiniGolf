using System.Collections;
using System.Collections.Generic;
using EasyMobile;
using UnityEngine;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        if (!RuntimeManager.IsInitialized())
        {
            RuntimeManager.Init();
            //Advertising.LoadInterstitialAd();
            //Advertising.LoadRewardedAd();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowBannerAd()
    {
        Advertising.ShowBannerAd(BannerAdPosition.Bottom);
        Debug.Log("Banner ad");
    }

    public void ShowIntestitialAd()
    {
        if (Advertising.IsInterstitialAdReady()) { 
            Advertising.ShowInterstitialAd();
            Debug.Log("Interstitial ad");
        }
    }

    public void ShowRewardAd()
    {
        if (Advertising.IsRewardedAdReady())
        {
            Advertising.ShowRewardedAd();
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        ShowBannerAd();
    }
}
