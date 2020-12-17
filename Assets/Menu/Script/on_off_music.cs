using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_music : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public AudioSource [] musics;

    public void toggleOnOff()
    {
        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            foreach (AudioSource music in musics)
            {
                music.volume = 1.0f;
            }
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            foreach (AudioSource music in musics)
            {
                music.volume = 0.0f;
            }
        }
    }
}
