using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_vibration : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public GameObject[] vibrations;
    private Player player;

    public void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        if (player.IsVibrationOn)
        {
            on.SetActive(true);
            off.SetActive(false);
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
        }
        
    }

    public void toggleOnOff()
    {
        player = GameObject.FindObjectOfType<Player>();
        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            player.IsVibrationOn = true;
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            player.IsVibrationOn = false;
        }
    }
}
