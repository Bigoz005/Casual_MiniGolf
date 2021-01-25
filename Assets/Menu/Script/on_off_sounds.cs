using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_sounds : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public AudioSource [] sounds;
    private Player player;

    public void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        refreshList();

        if (player.IsSoundOn)
        {
            on.SetActive(true);
            off.SetActive(false);

            foreach (AudioSource sound in sounds)
            {
                if (sound.tag == "Sound_Source")
                {
                    sound.volume = 1.0f;
                }

                if (sound.tag == "Ball_Sound_Source")
                {
                    sound.volume = 1.0f;
                }
            }
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);

            foreach (AudioSource sound in sounds)
            {
                if (sound.tag == "Sound_Source")
                {
                    sound.volume = 0.0f;
                }

                if (sound.tag == "Ball_Sound_Source")
                {
                    sound.volume = 0.0f;
                }
            }
        }
    }

    public void refreshList()
    {
        sounds = GameObject.FindObjectsOfType<AudioSource>();
    }

    public void toggleOnOff()
    {
        refreshList();

        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            player.IsSoundOn = true;
            foreach(AudioSource sound in sounds)
            {
                if (sound.tag == "Sound_Source")
                {
                    sound.volume = 1.0f;
                }

                if (sound.tag == "Ball_Sound_Source")
                {
                    sound.volume = 1.0f;
                }
            }
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            player.IsSoundOn = false;
            foreach (AudioSource sound in sounds)
            {
                if (sound.tag == "Sound_Source")
                {
                    sound.volume = 0.0f;
                }

                if (sound.tag == "Ball_Sound_Source")
                {
                    sound.volume = 0.0f;
                }
            }
        }
    }
}
