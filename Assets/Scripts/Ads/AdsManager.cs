using System.Collections;
using System.Collections.Generic;
using EasyMobile;
using UnityEngine;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour
{
    public bool interstitialClosed = true;
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
            interstitialClosed = false;
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

    IEnumerator CloseAfterTime(float time)
    {
        yield return new WaitForSeconds(time);


    }

    // Subscribe to the event
    void OnEnable()
    {
        Advertising.InterstitialAdCompleted += InterstitialAdCompletedHandler;
    }

    // The event handler
    void InterstitialAdCompletedHandler(InterstitialAdNetwork network, AdLocation location)
    {
        interstitialClosed = true;
        Debug.Log("Interstitial ad has been closed.");
    }

    // Unsubscribe
    void OnDisable()
    {
        Advertising.InterstitialAdCompleted -= InterstitialAdCompletedHandler;
    }
}
