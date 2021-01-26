using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Club : MonoBehaviour
{
    string[] namesArray = { "Putter", "Drive" };
    public string clubName = "";

    public GameObject driver;
    public GameObject putter;

    void Start()
    {
        clubName = namesArray[0];
    }

    private void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ChangeClub();
            }
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount == 2)
            {
                Touch touch = Input.GetTouch(1);

                if (touch.phase == TouchPhase.Ended)
                {
                    ChangeClub();
                }
            }
        }
        /*
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up, -10);
        }
    
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.up, 2);
        }
        */
    }

    public void ChangeClub()
    {
        if (clubName == namesArray[0])
        {
            clubName = namesArray[1];

            driver.SetActive(true);
            putter.SetActive(false);
        }
        else
        {
            clubName = namesArray[0];
            driver.SetActive(false);
            putter.SetActive(true);
        }
        GetComponentInParent<AudioSource>().Play();
    }
}