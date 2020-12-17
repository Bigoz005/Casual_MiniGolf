using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_sounds : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public AudioSource [] sounds;

    public void toggleOnOff()
    {
        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            foreach(AudioSource sound in sounds)
            {
                sound.volume = 1.0f;
            }
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            foreach (AudioSource sound in sounds)
            {
                sound.volume = 0.0f;
            }
        }
    }
}
