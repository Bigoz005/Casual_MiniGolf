using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToMenu : MonoBehaviour
{

    public GameObject menu;
    public GameObject options;

    private AdsManager adsManager;

    public void Start()
    {
        this.gameObject.AddComponent<AdsManager>();
        adsManager = this.gameObject.GetComponent<AdsManager>();
        adsManager.ShowBannerAd();
    }

    public void toMenu()
    {
        if (!menu.activeSelf)
        {
            menu.SetActive(true);
            options.SetActive(false);
        }
        else
        {
            menu.SetActive(false);
            options.SetActive(true);
        }
    }
}