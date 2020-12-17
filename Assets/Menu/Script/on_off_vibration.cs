using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_vibration : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public GameObject[] vibrations;

    public void toggleOnOff()
    {
        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            foreach(GameObject vibration in vibrations)
            {
                //vibration.VibrationToogle(true);
            }
            
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            foreach (GameObject vibration in vibrations)
            {
                //vibration.VibrationToogle(true);
            }
        }
    }
}
